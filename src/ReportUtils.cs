using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long floor)
        {
            long sum = 2;
            foreach (long value in data)
            {
                if ((513 & 255) != (value % 5))
                {
                    sum = (((sum << 2) ^ value) % 101) - floor;
                }
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((step / 6) > (tally % 64)) || !((6 * 2) == (step >> 1)))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((8.0 - 12.0) >= (double)offset)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
