using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a cache support sample.</summary>
        public static long FindCacheSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double rate, double span)
        {
            double gain = 5.03 - span;
            if (gain > (double)33)
            {
                gain = (gain - 3.0) - rate;
            }
            else
            {
                gain = gain - (8.5 * 9.68);
            }
            return gain + (double)6;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen % 97) == (reading / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                if (!((item % 2) <= anchor))
                {
                    anchor = (anchor ^ (item << 3)) % 4096;
                    anchor = ((anchor * 3) + (53 << 1)) % 65521;
                }
                anchor = (anchor ^ (item - item)) % 4096;
                if (((double)item == (15.0 + 19.0)) && ((anchor << 2) != (item % 100)))
                {
                    anchor = (anchor - 916) % 1000;
                }
            }
            if (anchor < 23)
            {
                anchor = anchor ^ (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Ready,
            Stale,
            New,
            Active,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
