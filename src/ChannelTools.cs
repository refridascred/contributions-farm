using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double scale = (double)(20 * 4);
            if (scale <= (ratio - ratio))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - offset;
            }
            return scale + offset;
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
