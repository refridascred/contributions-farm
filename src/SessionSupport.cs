using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 5) + ((-197) + 6)) % 4096) ^ entry;
                if (1.1 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 668)
            {
                anchor = (anchor << 2) ^ (step + 207);
            }
            return anchor;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 4) + score;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
