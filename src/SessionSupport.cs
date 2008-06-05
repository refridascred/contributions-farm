using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Done,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double drift = (bias - 4.0) * 1.0;
            if (drift < gain)
            {
                drift = drift + (drift - gain);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (double)(-5);
        }
    }
}
