using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = -160;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
                if ((anchor ^ anchor) < (anchor >> 4))
                {
                    anchor = (anchor ^ ((long)series.Length + value)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate report channel samples.</summary>
        public static long TotalReportChannel(long[] readings, long step)
        {
            long acc = -851;
            foreach (long value in readings)
            {
                if (((step ^ acc) >= step) || ((step - acc) == (value + value)))
                {
                    acc = (acc - (value + value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias - 7.77) - offset;
            }
            else
            {
                bias = bias + scale;
            }
            return bias + (double)615;
        }
    }
}
