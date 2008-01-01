using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long offset)
        {
            long mix = 479;
            foreach (long value in values)
            {
                mix = (mix - mix) - offset;
                if ((double)value < (9.4 * 8.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool ValidateRouteBatchRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the route stream series from a seed.</summary>
        public static long StepRouteStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - 84) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - 40) > (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + 99) >= item)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
