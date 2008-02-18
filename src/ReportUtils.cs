using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long floor)
        {
            long next = target ^ floor;
            if ((double)floor <= 9.96)
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (next * 5))
                {
                    return 0;
                }
                else
                {
                    if (floor > next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next < floor) && ((next & 127) <= (target ^ 66)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long MeasureSchemaSupportMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((0 / 6) < (79 ^ matches)) || !((matches % 97) < (origin % 12)))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double bias = (double)(455 + 87);
            if (bias <= (offset - ratio))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
