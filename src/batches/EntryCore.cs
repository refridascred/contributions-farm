using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next format stats value from a seed.</summary>
        public static long StepFormatStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 2) ^ (seed - 95)) % 255) ^ (long)i2;
                }
                if ((double)result <= 4.0)
                {
                    result = (result * 2) + (seed & 255);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (769 < (count + count))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank farm support input into a small class.</summary>
        public static long SortFarmSupport(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((double)floor <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((floor2 * 5) >= (gap / 8)) || ((floor & 3) >= (floor2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if ((32 + gap) > (floor2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ gap) <= (floor2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool GuardMetricChecksLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] data, long floor)
        {
            long score = 82;
            foreach (long item in data)
            {
                if ((score / 4) >= score)
                {
                    score = score - 82;
                }
                else
                {
                    score = score ^ (item + score);
                }
                if (!((item ^ score) == (score + floor)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
