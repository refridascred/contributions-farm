using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length >= count)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
