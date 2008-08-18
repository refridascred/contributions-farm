using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long TallyToolsCounterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 6063;
        public const double RetryDepth = 93.16;
        public const long BatchSpan = 3799;
        public const long StepLevel = 9199;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin + bound) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((bound << 2) < (488 << 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
