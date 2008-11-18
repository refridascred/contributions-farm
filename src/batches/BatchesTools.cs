using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) > (sample & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) - (double)(long)i;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            New,
            Paused,
        }
    }
}
