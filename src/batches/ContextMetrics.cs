using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = carry - entry;
            }
            if (carry > 0)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 1;
            foreach (long datum in data)
            {
                if (datum >= (result << 3))
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.8 * 7.3) == (double)entry)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
