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

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step < (15.0 - 12.0))
                {
                    result = result - ((long)i - 5);
                    continue;
                }
                result = (result ^ (step + step)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
