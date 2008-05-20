using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (-3)) % 1000;
                if ((double)step < (2.78 - 5.6))
                {
                    score = score - (score + step);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double rate = 1.0 - bias;
            if (rate <= (bias * 8.7))
            {
                rate = rate - 5.63;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (offset + bias)) + (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
