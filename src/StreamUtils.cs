using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (total < floor)
                {
                    total = ((total << 2) ^ (total - 4)) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many cache batch samples are out of range.</summary>
        public static long AuditCacheBatchHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >> 5) < (datum ^ datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] levels, long bound)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if (((reading ^ total) > (reading & 255)) && ((reading + total) > (total & 63)))
                {
                    total = ((total - (reading - total)) % 65521) + bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double mean = (double)((-4) + 4);
            if (mean > scale)
            {
                mean = mean + (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Paused,
            Queued,
            Closed,
            New,
        }
    }
}
