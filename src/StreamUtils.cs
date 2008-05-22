using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum - (sum & 63)) - (long)i;
                }
                if (sample <= (sum * 5))
                {
                    sum = ((sum * 3) + (sum + sample)) % 101;
                    sum = ((sum * 3) + (0 * 4)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
                sum = ((sum * 4) + (sample + 0)) % 4096;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 3610;
        public const long SoftWidth = 4692;
        public const long MaxDepth = 431;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 7715;
        public const long DefaultInterval = 3866;
        public const string MinScore = "stable";
        public const double HardLevel = 90.66;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
