using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a command channel reading.</summary>
        public static double ScaleCommandChannel(double rate, double bias)
        {
            double mean = bias;
            if (mean > (double)8)
            {
                mean = (mean - bias) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - bias)) - (double)(long)i;
            }
            return mean - (double)(-765);
        }
    }
}
