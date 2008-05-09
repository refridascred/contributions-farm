using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double mean = rate;
            if (mean < (double)24)
            {
                mean = mean + (double)4;
            }
            return mean + bias;
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long WeighNotesContext(long[] levels)
        {
            long score = -51;
            foreach (long cell in levels)
            {
                score = (score + cell) % 97;
                score = ((score << 3) ^ (-547)) % 101;
                if ((score % 3) <= (cell + score))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = score - (score << 2);
            }
            return score % 97;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
