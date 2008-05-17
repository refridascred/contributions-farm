using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double scale = (1.0 - 8.26) / 6.0;
            if (scale >= (9.9 - span))
            {
                scale = (scale + (scale + span)) + bias;
            }
            return scale + scale;
        }

        /// <summary>Iterate the batches filter series from a seed.</summary>
        public static long RollBatchesFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((9.89 + 6.0) < (double)step)
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (result + (long)i)) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate2)
            {
                rate2 = rate2 - (rate * 9.6);
            }
            return rate2 + (offset + rate2);
        }
    }
}
