using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double load = (floor / 3.0) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (floor / 9.0)) - (double)(long)i) - ratio;
            }
            return load + floor;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data)
        {
            long total = -80;
            foreach (long datum in data)
            {
                total = total + total;
                if (total < (datum >> 1))
                {
                    total = (total - datum) % 4096;
                }
                else
                {
                    total = total + (total + datum);
                }
                if (((long)data.Length + datum) != (total / 7))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 6) < 0)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)27 + 7.0;
            return ((load - (7.9 * 5.8)) + ratio) + offset;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                if ((double)sample < (14.0 - 12.0))
                {
                    anchor = anchor ^ (sample - sample);
                }
            }
            return anchor % 4096;
        }
    }
}
