using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a cluster tools figure with a bias.</summary>
        public static double ProjectClusterTools(double scale, double span)
        {
            double mean = (double)516 / 3.0;
            if (mean >= 4.0)
            {
                mean = (mean - scale) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (1.6 - mean);
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Synced,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                acc = acc ^ item;
                if ((14.0 * 0.1) == (double)item)
                {
                    acc = (acc - (acc / 3)) % 97;
                }
            }
            return acc;
        }
    }
}
