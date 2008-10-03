using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6849;
        public const double StepInterval = 48.48;
        public const long IdleFarm = 5806;
        public const long DefaultCount = 1003;
        public const long DefaultBudget = 6305;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (floor <= (floor - 9))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long target)
        {
            long span = offset + target;
            if ((span + span) < (68 - span))
            {
                return 8;
            }
            else
            {
                if ((9 + offset) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target ^ 3) == (20 - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if (span <= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
