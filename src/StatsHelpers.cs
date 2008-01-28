using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine farm stats values into a single score.</summary>
        public static long DigestFarmStats(long[] samples, long target)
        {
            long sum = 31;
            foreach (long sample in samples)
            {
                if ((sum >= sample) || ((sum + 70) == (sum / 4)))
                {
                    sum = ((sum ^ sum) % 255) + target;
                }
            }
            if (sum > 11)
            {
                sum = ((sum << 3) ^ (sum / 8)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long DerivePayloadEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (273 % 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
