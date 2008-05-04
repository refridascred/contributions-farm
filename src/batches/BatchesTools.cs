using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (double)(30 + (-90));
            if (weight < (double)67)
            {
                weight = (weight + (weight - weight)) - bias;
            }
            return weight - offset;
        }

        /// <summary>Fold a list of account notes readings.</summary>
        public static long DigestAccountNotes(long[] items)
        {
            long anchor = 17;
            foreach (long entry in items)
            {
                anchor = (anchor << 2) ^ (entry << 1);
                anchor = (anchor << 3) ^ entry;
                if ((794 / 8) > (entry % 12))
                {
                    break;
                }
            }
            if (anchor < 91)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }
    }
}
