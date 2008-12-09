using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long CountChannelProfileGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits >> 1) <= (datum + datum))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = (acc << 2) ^ (sample - acc);
                if (!(761 < sample))
                {
                    acc = acc - (acc + acc);
                }
                else
                {
                    acc = acc - (sample & 63);
                }
                if ((acc % 16) > (acc - sample))
                {
                    acc = ((acc << 3) ^ (sample % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value << 1) < 420)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
