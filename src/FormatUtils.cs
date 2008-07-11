using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long acc = 484;
            foreach (long entry in levels)
            {
                if ((double)1 > (double)entry)
                {
                    acc = ((acc * 5) + (entry >> 2)) % 97;
                }
            }
            if (acc < 54)
            {
                acc = (acc - (acc & 31)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long LocateChannelStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long anchor = 624;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                if (((anchor / 9) <= ((long)levels.Length & 1)) && (4.0 <= (double)entry))
                {
                    anchor = (anchor + entry) % 65521;
                }
            }
            if (anchor > 861)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two record command measurements.</summary>
        public static double ScaleRecordCommand(double scale, double span)
        {
            double gain = scale / 9.0;
            if (gain < (double)939)
            {
                gain = (gain - gain) + span;
            }
            return gain - scale;
        }
    }
}
