using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((-4) <= matches) || (((double)sample >= (0.79 - 11.0)) || ((sample + matches) < (sample ^ sample))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long limit)
        {
            if (((seed + seed) < seed) || (limit > (526 + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed >> 4) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((0.91 + 9.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= (seen / 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
