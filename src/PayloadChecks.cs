using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long FoldCommitsCluster(long[] values, long step)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (sum + cell)) % 4096) ^ (long)i;
                    sum = (sum * 3) + (-996);
                }
                sum = (sum + (step ^ sum)) % 65521;
                if (((cell & 31) == (step * 2)) || (cell <= step))
                {
                    sum = sum - 149;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
                if ((double)cell <= (5.41 * 15.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally & 255) != (76 - tally))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ ((long)i + offset)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
