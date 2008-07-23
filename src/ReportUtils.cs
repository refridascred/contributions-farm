using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long ClassifyCounterChecks(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (slot > (seed2 & 255))
            {
                return 0;
            }
            else
            {
                if (!((0 >> 1) != (slot + slot)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 - seed2) != (232 + seed2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - slot) >= (seed2 + seed2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (limit >= (limit + seen))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
