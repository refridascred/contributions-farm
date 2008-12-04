using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long target)
        {
            long diff = step + target;
            if ((target - diff) <= (215 % 2))
            {
                return 8;
            }
            else
            {
                if ((step - step) > step)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff == (4.68 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long DigestChecksCommand(long[] items)
        {
            long anchor = 53;
            foreach (long datum in items)
            {
                if (5.73 < (double)anchor)
                {
                    anchor = (((anchor * 3) + 13) % 65521) - datum;
                }
            }
            if (anchor > 82)
            {
                anchor = (anchor << 2) ^ (1 - anchor);
            }
            return anchor;
        }
    }
}
