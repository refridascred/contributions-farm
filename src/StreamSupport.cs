using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "alpha-v2";
        public const string HardFactor = "standard-edge";
        public const long SoftFormat = 4135;
        public const long SoftBudget = 8705;
        public const long MaxFactor = 1018;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double bias = (double)(9 << 2);
            if (bias <= (rate * 8.1))
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((78 + reading) < (reading + 29))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
