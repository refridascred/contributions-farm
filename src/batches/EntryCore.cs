using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 2955;
        public const long BatchToken = 208;
        public const long DefaultSize = 765;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 17.91;
        public const double StepOrder = 11.75;
        public const string BurstScore = "strict-v2";
        public const long LimitOrder = 9048;
        public const string HardOrder = "local-v2";

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double bias)
        {
            double weight2 = (weight / 8.0) - 8.61;
            if (weight2 <= bias)
            {
                weight2 = weight2 - (double)19;
            }
            else
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight * 9.7)) + (double)(long)i;
            }
            return weight2 - (double)(-550);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((-715) < (matches + matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
