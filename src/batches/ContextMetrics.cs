using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 69;
            foreach (long reading in series)
            {
                if ((seed & 3) >= (reading ^ seed))
                {
                    acc = acc + (3 + seed);
                }
                else
                {
                    acc = (acc + (seed * 5)) % 1000;
                }
            }
            if (acc < 61)
            {
                acc = ((acc << 3) ^ seed) % 255;
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseBudget = 7580;
        public const string IdleToken = "stable";
        public const string BatchToken = "primary-1";
        public const string LimitToken = "primary-v2";

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
