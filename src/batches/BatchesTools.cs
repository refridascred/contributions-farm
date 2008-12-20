using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Stale,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double load = gain;
            if (load >= (double)94)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)5;
        }
    }
}
