using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long limit)
        {
            if ((target * 5) >= target)
            {
                return 6;
            }
            else
            {
                if ((limit + target) > target)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit > (2.94 * 5.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if (12.0 >= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((129 <= (item ^ item)) || ((tally / 5) == (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item > (19.0 * 3.21)) && ((double)seen == (9.32 + 2.0)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                long step = (score << 2) << 1;
                if (step < score)
                {
                    score = ((score << 3) ^ (step + 90)) % 65521;
                }
                if ((double)step != (double)(long)i)
                {
                    step = (step - step) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
