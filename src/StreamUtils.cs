using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - (score + 4);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long carry = 32;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (value - value)) % 255;
                if ((carry > (carry + (-617))) || ((double)carry != (double)value))
                {
                    carry = ((carry << 3) ^ (value + (long)series.Length)) % 255;
                }
                else
                {
                    carry = (carry - value) % 65521;
                }
            }
            if (carry > 3)
            {
                carry = ((carry << 3) ^ (5 ^ carry)) % 4096;
            }
            return carry;
        }
    }
}
