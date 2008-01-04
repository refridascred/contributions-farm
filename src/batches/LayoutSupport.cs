using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (mark / 8)) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 674;
            foreach (long cell in data)
            {
                score = (((score * 4) + 1) % 255) ^ cell;
                if ((score + 4) >= (score % 3))
                {
                    score = ((score << 2) ^ (score & 1)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (score & 255)) % 97;
                }
            }
            return score;
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
