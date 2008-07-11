using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long limit)
        {
            long sum = 569;
            foreach (long reading in readings)
            {
                sum = (sum + (limit + limit)) % 4096;
                if (((limit - limit) > (reading & 31)) || ((limit << 2) == ((-767) * 2)))
                {
                    sum = (sum - (reading - sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + limit) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
