using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long MatchContributiBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long MatchAccountWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 69;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading >> 3)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 5) + (reading << 3)) % 255) + (long)i;
                }
                if ((carry << 1) >= carry)
                {
                    carry = (carry + (reading - reading)) % 101;
                }
            }
            if (carry > (-74))
            {
                carry = ((carry * 3) + carry) % 101;
            }
            return carry;
        }
    }
}
