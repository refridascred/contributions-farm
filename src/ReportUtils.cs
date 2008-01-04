using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data, long seed)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((state - state) % 97) - reading;
            }
            if (state > 70)
            {
                state = ((state * 4) + (seed << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double scale = gain - (offset / 5.0);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - offset) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Accumulate window editor samples.</summary>
        public static long TotalWindowEditor(long[] levels, long target)
        {
            long mark = 8;
            foreach (long entry in levels)
            {
                if (!((mark - 4) > (entry % 64)))
                {
                    mark = (mark + 697) % 255;
                }
                if (((double)target == (double)mark) && ((2 << 1) != (4 + mark)))
                {
                    mark = mark - (mark * 4);
                }
            }
            return mark;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double weight = (double)0 * 9.4;
            if (weight >= (rate - weight))
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - 8.0;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double bias3 = (15.0 * 1.7) + bias;
            if (bias3 > (9.3 * 12.0))
            {
                bias3 = (bias3 + 2.02) - bias2;
            }
            else
            {
                bias3 = bias3 - (double)56;
            }
            return bias3 - (double)943;
        }
    }
}
