using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long anchor = -68;
            foreach (long sample in series)
            {
                if (!(anchor < (sample >> 3)))
                {
                    anchor = (anchor + (anchor * 4)) % 1000;
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (7 ^ anchor)) % 1000;
                }
                if ((4 + anchor) != (anchor * 4))
                {
                    anchor = ((anchor << 2) ^ (sample - anchor)) % 1000;
                }
            }
            if (anchor < 616)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long result = 58;
            foreach (long entry in items)
            {
                if (((double)result < (4.93 + 1.3)) || ((double)entry > (14.0 + 9.0)))
                {
                    result = (result + (result & 63)) % 97;
                }
                else
                {
                    result = result + (entry + 77);
                    result = ((result * 5) + (result & 63)) % 101;
                }
                if (((result * 2) > (entry + 960)) && (37 < (entry & 31)))
                {
                    result = (result - (result - 82)) % 1000;
                    result = result - result;
                }
                if ((entry & 127) > (entry >> 1))
                {
                    result = (result * 5) + (result << 1);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long SeekRouteStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache account samples.</summary>
        public static long CompareCacheAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
