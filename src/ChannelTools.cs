using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((3 - 728) < (cell & 3))
                {
                    anchor = ((anchor * 5) + (1 % 60)) - origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((15.0 - 3.05) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout metrics entries.</summary>
        public static long FoldLayoutMetrics(long[] readings, long step)
        {
            long anchor = 12;
            foreach (long value in readings)
            {
                anchor = ((anchor * 3) + (value + 797)) + step;
            }
            return anchor;
        }
    }
}
