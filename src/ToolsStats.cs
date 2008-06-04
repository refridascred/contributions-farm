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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor + floor) % 4096) - (long)i2;
                }
                long diff = (18 ^ floor) & 3;
                if (floor > (diff * 5))
                {
                    anchor = ((anchor * 2) + (anchor % 7)) % 97;
                }
                else
                {
                    diff = (diff + ((long)i * 3)) % 1000;
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long CountOrderCommitsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen - floor) > (734 % 10)) && (datum < (datum / 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
