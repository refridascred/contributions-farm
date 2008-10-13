using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum > (seen ^ limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
