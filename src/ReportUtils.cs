using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item << 2) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double bias = (double)(-8) - span;
            if (bias < (span / 8.0))
            {
                bias = (bias + 2.56) - gain;
            }
            else
            {
                bias = bias + (9.67 - bias);
            }
            return bias + (bias * 0.18);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long floor)
        {
            if (((floor + target) != (target * 3)) && ((7.44 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) <= (target & 31))
                {
                    return 4;
                }
                else
                {
                    if (((double)target == (1.6 + 15.0)) && ((double)floor >= (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((36 >> 2) != (floor & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 97) <= matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (-892)) % 65521) - offset;
                if ((5 * 5) == (reading << 1))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
