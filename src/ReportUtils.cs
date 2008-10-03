using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = ratio * 10.0;
            if (drift >= (double)60)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - ratio;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long seed)
        {
            if ((seed + offset) < (seed - offset))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (8.0 - 5.05))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > (limit / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
