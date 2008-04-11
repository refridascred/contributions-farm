using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long lane = seed + floor;
            if (258 <= (lane + lane))
            {
                return 8;
            }
            else
            {
                if (!(floor > seed))
                {
                    return 7;
                }
                else
                {
                    if (((seed * 3) > floor) && ((6.7 / 9.0) > (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane - floor) > (floor / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 5887;
        public const double WindowEntry = 92.59;
        public const long DefaultCount = 445;
        public const long StepRatio = 7297;

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
