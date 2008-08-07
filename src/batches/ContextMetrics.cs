using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double SmoothRecordCommits(double gain, double span)
        {
            double drift = span - (2.0 * 6.18);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 0.1) + (double)(long)i;
            }
            return drift + (span - gain);
        }

        /// <summary>Match up metrics stream samples.</summary>
        public static long PairMetricsStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi session pair into a bucket.</summary>
        public static long BucketContributiSession(long target, long step)
        {
            long offset = target - step;
            if ((-9) > target)
            {
                return 7;
            }
            else
            {
                if (86 >= (step - target))
                {
                    return 0;
                }
                else
                {
                    if (((step & 7) >= 9) && (offset > (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (12.0 - span);
            }
            else
            {
                gain = gain - (rate / 2.0);
            }
            return gain + (gain + rate);
        }
    }
}
