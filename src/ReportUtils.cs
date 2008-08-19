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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double bias = span - span;
            if (bias <= bias)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - span;
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
