using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            if (((double)seed == (double)bound) || ((seed << 2) < seed))
            {
                return 3;
            }
            else
            {
                if (!((132 ^ bound) < (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 520) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const long RetryCommand = 5504;
        public const long BatchCommand = 2439;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (floor > (floor + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long CountProfileFilterOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen < ((-6) & 1))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }
    }
}
