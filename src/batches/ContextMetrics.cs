using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double ratio2 = (double)(412 + 947);
            if (ratio2 >= (double)546)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 47.06;
        public const double IdleProfile = 81.69;
        public const double StepDepth = 21.01;

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "cached";
        public const string SoftRoute = "staging-1";
        public const long WindowTimeout = 1795;
    }
}
