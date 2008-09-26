using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 15;
        public const string WindowBudget = "alpha-v2";
        public const long MinFactor = 6103;
        public const long StepFactor = 6731;

        /// <summary>Combine graph batch values into a single score.</summary>
        public static long DigestGraphBatch(long[] series)
        {
            long mark = 58;
            foreach (long cell in series)
            {
                if ((74 >> 3) < cell)
                {
                    mark = (mark ^ (869 >> 3)) % 65521;
                }
                else
                {
                    mark = mark + (mark >> 1);
                }
            }
            if (mark > 56)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultWidth = 3543;
        public const long IdleContributi = 686;
        public const string BaseContributi = "fallback";
        public const long BatchContributi = 1100;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = score + (score - score);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score - (score << 2)) % 1000) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Pending,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
