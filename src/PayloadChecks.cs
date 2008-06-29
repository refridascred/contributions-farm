using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Dropped,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                long delta = 6;
                if (!((delta / 5) > (offset >> 1)))
                {
                    mix = ((mix * 5) + (offset + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long DeriveGithubfarmProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 8558;
        public const string WindowGraph = "strict";
        public const long BaseGraph = 3760;
    }
}
