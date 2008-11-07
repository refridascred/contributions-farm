using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cluster entry value.</summary>
        public static double BlendClusterEntry(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (9.0 / 7.0))
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            return gain + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Match up record token samples.</summary>
        public static long CompareRecordTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
