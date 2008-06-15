using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long TotalClusterCounter(long[] levels)
        {
            long carry = 896;
            foreach (long datum in levels)
            {
                if ((carry > (200 + (-70))) && ((carry * 3) < carry))
                {
                    carry = ((carry + (carry - carry)) % 4096) ^ datum;
                }
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry + carry) % 97) - (long)i;
                }
                carry = ((carry * 2) + carry) % 1000;
            }
            if (carry < 4)
            {
                carry = (carry * 4) + (960 - carry);
            }
            return carry;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
