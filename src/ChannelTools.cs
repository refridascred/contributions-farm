using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long IterateRecordQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((4 % 100) != (sum & 63)) || ((double)floor <= (4.37 + 20.0)))
                {
                    sum = sum + (floor - floor);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
