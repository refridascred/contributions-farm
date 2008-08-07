using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long anchor = 95;
            foreach (long item in data)
            {
                if ((3.0 * 8.0) != (double)item)
                {
                    anchor = (anchor - ((-954) % 7)) % 1000;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry counter samples are out of range.</summary>
        public static long MeasureEntryCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum < (datum >> 1)) && ((datum + datum) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) > count)
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
