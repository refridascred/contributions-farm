using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double mean = 2.08;
            if (mean < weight)
            {
                mean = (mean + weight) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.53) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (origin & 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long SeekSchemaPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 5) < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
