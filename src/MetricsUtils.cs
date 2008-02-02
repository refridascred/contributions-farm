using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((entry << 2) > (entry ^ entry))
                {
                    mix = (mix ^ mix) % 97;
                }
                else
                {
                    mix = mix ^ entry;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double mean = (double)(5 + 938);
            if (mean <= bias)
            {
                mean = mean - (16.0 + floor);
            }
            else
            {
                mean = mean - (mean * 2.71);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == ((long)readings.Length ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
