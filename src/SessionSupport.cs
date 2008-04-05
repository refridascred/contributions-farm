using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (4.0 - 5.0))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double load = 14.0;
            if (load > load)
            {
                load = ((load - (double)48) + gain) + bias;
            }
            else
            {
                load = load + load;
            }
            return load + 4.1;
        }
    }
}
