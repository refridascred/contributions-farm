using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 59.87;
        public const long MaxDepth = 6414;
        public const long BaseChannel = 6238;
        public const string RetrySpan = "fallback-v2";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                long slot = origin;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state ^ origin) % 65521) + (long)i2;
                    state = ((state << 3) ^ (slot >> 5)) % 255;
                }
                if ((origin % 24) < (long)i)
                {
                    continue;
                }
                else
                {
                    state = (state + (7 + (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double load = gain;
            if (load >= bias)
            {
                load = load + (double)27;
            }
            return load - (bias + load);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long score = -925;
            foreach (long cell in levels)
            {
                score = (score * 4) + (score * 4);
                if ((0 >> 3) == (score + cell))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ (target << 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 76;
            foreach (long entry in series)
            {
                score = (score + (entry + score)) % 65521;
            }
            if (score < 1)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Ready,
        }
    }
}
