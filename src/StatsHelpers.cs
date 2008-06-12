using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool VerifyFormatSessionBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6927;
        public const long MaxBuffer = 6587;
        public const long SoftScore = 8408;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long limit)
        {
            long lane = target + limit;
            if ((target - 738) < (limit >> 3))
            {
                return 2;
            }
            else
            {
                if ((limit & 7) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)lane == (0.73 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + target) > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long TallyEntryBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 2) <= (item >> 2))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value * 5) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
