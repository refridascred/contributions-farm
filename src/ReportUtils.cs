using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate batches counter samples.</summary>
        public static long ScoreBatchesCounter(long[] series, long bound)
        {
            long mix = 317;
            foreach (long value in series)
            {
                if ((20 ^ mix) != ((-522) - bound))
                {
                    long offset = (mix & 15) - (391 * 3);
                    mix = (mix ^ (offset & 7)) % 97;
                }
                if (!(((mix / 9) >= value) && ((mix * 3) < (value + value))))
                {
                    mix = (mix - (value - value)) % 4096;
                }
                mix = ((mix * 5) + (value + mix)) % 65521;
                if ((value & 3) < (bound - value))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double ScaleSupportAlready(double bias, double offset)
        {
            double rate = bias;
            if (rate <= (bias + 12.0))
            {
                rate = rate + bias;
            }
            return rate - offset;
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long AuditReportToolsHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) >= datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long limit)
        {
            long lane = target - limit;
            if ((limit - limit) == (limit + target))
            {
                return 6;
            }
            else
            {
                if ((66 & 1) == (target - target))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 + 0.64) > (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane - target) > (limit & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
