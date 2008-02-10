using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long origin)
        {
            long mix = 255;
            foreach (long item in items)
            {
                mix = ((mix ^ item) % 65521) + origin;
            }
            if (mix > 7)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally / 2) > (reading + 405))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double gain = (floor * 8.0) + (double)11;
            if (gain > floor)
            {
                gain = (gain - (18.0 / 7.0)) - ratio;
            }
            else
            {
                gain = gain + (double)(-930);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 1.4;
        }
    }
}
