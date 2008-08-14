using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long acc = 267;
            foreach (long datum in samples)
            {
                acc = (((acc * 3) + 996) % 255) - datum;
            }
            if (acc < 640)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next payload contributi value.</summary>
        public static double BlendPayloadContributi(double rate, double floor)
        {
            double scale = floor;
            if (scale >= floor)
            {
                scale = scale - (double)3;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (rate + floor);
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long TallySessionProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((99 & 15) < (sample + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
