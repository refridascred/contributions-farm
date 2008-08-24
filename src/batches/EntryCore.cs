using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.14 * 2.57))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardScore = 4643;
        public const long BatchEntry = 7757;
        public const long DefaultSize = 4622;
        public const double SoftSize = 95.95;
        public const long LimitEntry = 5183;

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            long lane = target ^ target2;
            if (lane >= target2)
            {
                return 2;
            }
            else
            {
                if ((target - target) <= (lane + 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 <= (0.75 * 3.92))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
