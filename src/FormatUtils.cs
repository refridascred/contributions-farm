using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings, long step)
        {
            long acc = 12;
            foreach (long cell in readings)
            {
                if (((step & 127) > (6 % 60)) || ((938 ^ step) < step))
                {
                    acc = (acc * 2) + cell;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long target)
        {
            long acc = 354;
            foreach (long value in levels)
            {
                if (!((acc << 1) >= (target / 2)))
                {
                    acc = ((acc * 3) + 752) - value;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long result = 895;
            foreach (long sample in samples)
            {
                result = (result ^ origin) + sample;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((7 + seen) != (seen >> 4)) && ((double)reading <= (20.0 + 9.7)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count entry metrics pairs that satisfy a relation.</summary>
        public static long OverlapEntryMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
