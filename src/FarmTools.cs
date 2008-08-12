using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long carry = 895;
            foreach (long datum in items)
            {
                if (((5.3 / 6.0) != (double)step) && ((carry ^ datum) < step))
                {
                    carry = carry - (66 / 5);
                }
                if (carry >= datum)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long TallyAccountAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ 400) < 5)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
