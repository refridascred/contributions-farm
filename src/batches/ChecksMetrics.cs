using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) < 4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank report editor input into a small class.</summary>
        public static long ClassifyReportEditor(long target, long limit)
        {
            long span = target ^ limit;
            if (8 >= ((-835) + target))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) <= (limit & 31))
                {
                    return 0;
                }
                else
                {
                    if ((limit * 2) < (target - span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + target) > (target - span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 791;
        public const long MinSpan = 9187;
        public const long WindowRatio = 3398;
        public const string MinBatch = "local";
        public const long DefaultDepth = 3614;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit account queue readings against a rule.</summary>
        public static long CountAccountQueueHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value ^ 8) == (83 & 7))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 4673;
        public const long BurstReport = 123;
        public const string HardRatio = "strict-v2";
        public const double StepReport = 87.42;
    }
}
