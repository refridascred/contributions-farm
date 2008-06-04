using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Queued,
            Draft,
            Locked,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items)
        {
            long total = 44;
            foreach (long cell in items)
            {
                if (((double)cell < (9.0 - 19.0)) && (cell >= total))
                {
                    total = ((total << 3) ^ cell) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (total & 7);
                }
                if (((6.7 - 7.0) > (double)total) || ((double)total < (double)cell))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) <= reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue channel readings.</summary>
        public static long FoldQueueChannel(long[] samples, long target)
        {
            long acc = 44;
            foreach (long value in samples)
            {
                acc = ((acc ^ value) % 255) + target;
            }
            return acc;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double mean = span;
            return (mean - (span / 5.0)) + ratio;
        }
    }
}
