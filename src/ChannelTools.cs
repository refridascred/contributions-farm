using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (-29)) % 97;
                if (!((floor / 9) != (value ^ floor)))
                {
                    carry = (carry - (carry >> 3)) % 1000;
                }
                if ((value * 5) != (carry / 6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate editor batches samples.</summary>
        public static long TallyEditorBatches(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                anchor = ((anchor * 5) + entry) % 4096;
                if ((anchor - entry) < (origin - entry))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor - origin)) % 101;
            }
            return anchor % 97;
        }
    }
}
