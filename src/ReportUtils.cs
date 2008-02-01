using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine entry notes values into a single score.</summary>
        public static long WeighEntryNotes(long[] series, long bound)
        {
            long sum = 2;
            foreach (long item in series)
            {
                double weight = (double)sum;
                if (weight >= (double)item)
                {
                    sum = (sum + bound) % 65521;
                }
                if ((4.35 / 8.0) <= (double)sum)
                {
                    sum = (sum - (bound + sum)) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (item >> 1)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = ((sum * 5) + (sum - sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long origin, long limit)
        {
            if ((limit / 4) < (8 << 2))
            {
                return 6;
            }
            else
            {
                if (limit < 0)
                {
                    return 4;
                }
                else
                {
                    if (!((double)917 == (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long limit)
        {
            if ((limit + offset) <= (6 >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) < (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((offset >> 5) <= (404 + limit)) || ((limit / 8) < 93))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit & 63) < 79)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
