using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long seed)
        {
            long carry = 31;
            foreach (long entry in samples)
            {
                carry = ((carry ^ 967) ^ entry) - seed;
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
