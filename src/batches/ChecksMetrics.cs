using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "fallback-1";
        public const string MaxCluster = "legacy";
        public const long BurstFactor = 343;
        public const string IdleCount = "stable-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 53.04;
        public const double BaseCount = 24.02;
        public const long StepSize = 5890;
        public const long BaseBudget = 9904;
        public const long LimitRatio = 6824;

        /// <summary>Compare every pair of batch report readings.</summary>
        public static long OverlapBatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ (-476)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (acc >> 4)) % 1000) - (long)i2;
                }
                acc = (acc ^ 471) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "latest";
        public const long WindowCount = 7804;
        public const long MinCount = 4696;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Ready,
            Synced,
        }
    }
}
