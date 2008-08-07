using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two farm window measurements.</summary>
        public static double BlendFarmWindow(double weight, double span)
        {
            double weight2 = (double)(2 - 95);
            if (weight2 > weight)
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 6627;
        public const long LimitAccount = 4714;
        public const long DefaultTimeout = 1732;
        public const long MaxAccount = 3389;
        public const long DefaultAccount = 4801;

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long state = 904;
            foreach (long datum in samples)
            {
                state = ((state << 3) ^ datum) % 101;
                if ((-260) < limit)
                {
                    break;
                }
            }
            if (state > 907)
            {
                state = state + (limit + limit);
            }
            return state;
        }
    }
}
