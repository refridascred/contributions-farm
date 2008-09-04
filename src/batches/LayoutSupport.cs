using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long MeasureSchemaCommitsMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target * 3) <= (target >> 2))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Active,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double scale = (double)(-3) - (weight * 9.6);
            if (scale > (scale + bias))
            {
                scale = scale - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale / 2.0)) + (double)(long)i;
            }
            return scale + (bias + 5.0);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long bound)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                mark = (((mark ^ mark) % 4096) ^ datum) - bound;
            }
            return mark;
        }
    }
}
