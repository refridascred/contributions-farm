using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5.23 <= (double)offset)
                {
                    score = (score ^ (34 >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the layout commits series from a seed.</summary>
        public static long DeriveLayoutCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long mix = 521;
            foreach (long entry in items)
            {
                if ((mix - 7) > (entry + mix))
                {
                    mix = (mix - ((-1) + entry)) % 4096;
                    mix = mix + entry;
                }
                if (!((entry << 2) <= entry))
                {
                    mix = (mix ^ (9 / 3)) % 97;
                }
                else
                {
                    mix = mix + (mix << 2);
                }
            }
            return mix;
        }
    }
}
