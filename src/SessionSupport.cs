using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long sum = 36;
            foreach (long sample in data)
            {
                if (22 < (8 + bound))
                {
                    sum = sum - sample;
                }
            }
            return sum;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double gain = (double)165 * 1.85;
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain - (double)25) + (double)(long)i) - scale) - bias;
            }
            return gain - gain;
        }
    }
}
