using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a session cluster figure with a bias.</summary>
        public static double AdjustSessionCluster(double gain, double bias)
        {
            double drift = (double)(33 / 2);
            if (drift >= drift)
            {
                drift = ((drift + (double)76) - gain) + bias;
            }
            else
            {
                drift = drift + 3.62;
            }
            return drift + (drift * 8.0);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Dropped,
            Paused,
            Draft,
            Closed,
        }
    }
}
