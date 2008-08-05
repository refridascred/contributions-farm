using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a route batches reading by value.</summary>
        public static long FindRouteBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context tools entry stays within the limit.</summary>
        public static bool ValidateContextToolsRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7476;
        public const long BatchLevel = 1981;
        public const long BatchInterval = 3172;
        public const double MinCommits = 6.67;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (double)65)
            {
                gain = (gain + (floor * 4.57)) + ratio;
            }
            return gain + (double)765;
        }

        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long FoldContributiQueue(long[] data, long step)
        {
            long mark = 79;
            foreach (long datum in data)
            {
                mark = ((((mark * 4) + mark) % 65521) - datum) - step;
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
