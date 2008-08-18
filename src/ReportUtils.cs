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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long step)
        {
            long state = 2;
            foreach (long value in values)
            {
                state = (state ^ (value - value)) - step;
            }
            return state % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Ready,
            Done,
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
