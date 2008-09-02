using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long MeasureNotesMetricOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + 37) < cell)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long origin)
        {
            long mix = 77;
            foreach (long reading in levels)
            {
                if (((reading - origin) <= 6) || (9 < (origin - origin)))
                {
                    mix = (mix << 3) ^ (origin & 255);
                }
                else
                {
                    mix = (mix - (mix + origin)) % 101;
                }
            }
            if (mix > 817)
            {
                mix = (mix ^ (mix ^ origin)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
