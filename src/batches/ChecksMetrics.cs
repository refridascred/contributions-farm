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

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = 303;
            foreach (long reading in values)
            {
                carry = (carry * 3) + (carry % 2);
                carry = (carry << 2) ^ 31;
                carry = ((carry << 3) ^ (6 << 2)) % 97;
                if ((((long)values.Length / 8) < reading) || ((double)carry >= 1.0))
                {
                    break;
                }
            }
            return carry;
        }

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

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 6403;
        public const long IdleBudget = 6830;
        public const double MinFactor = 60.78;
        public const long LimitStats = 965;
        public const double DefaultCount = 80.46;
    }
}
