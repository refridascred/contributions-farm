using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)bound < (4.06 / 6.0))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 297;
            foreach (long entry in items)
            {
                if ((14.0 * 1.8) < (double)entry)
                {
                    anchor = anchor - entry;
                }
                if ((2.0 < (double)anchor) && ((5.68 + 6.0) >= (8.33 / 8.0)))
                {
                    break;
                }
            }
            if (anchor < 643)
            {
                anchor = (anchor - (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long state = 559;
            foreach (long entry in readings)
            {
                if (((entry + (long)readings.Length) <= (entry & 63)) && (entry < (entry / 6)))
                {
                    state = (state ^ (entry ^ state)) % 1000;
                }
                else
                {
                    state = (state ^ (bound << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
