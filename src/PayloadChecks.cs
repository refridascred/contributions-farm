using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (count - item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 1449;
        public const string StepWidth = "alpha-v2";
        public const string SoftRoute = "stable";
        public const long StepRoute = 3224;

        /// <summary>Validate token stats readings against a bound.</summary>
        public static bool CheckTokenStatsRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token profile counter forward.</summary>
        public static long SeriesTokenProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (-4)) % 101;
                state = state - ((long)i + bound);
                state = state + (bound + (long)i);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Paused,
            Queued,
        }
    }
}
