using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target & 3) > (target ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 3) >= (offset ^ lane))
            {
                return 2;
            }
            else
            {
                if (((target + lane) >= offset) || (offset <= (target & 15)))
                {
                    return 8;
                }
                else
                {
                    if (target >= (lane % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = scale;
            if (gain < (gain + scale))
            {
                gain = (gain + (gain / 4.0)) - floor;
            }
            else
            {
                gain = gain - (11.0 + scale);
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double load = (double)(6 - 320);
            if (load < (load * 18.0))
            {
                load = load - floor;
            }
            else
            {
                load = load + bias;
            }
            return load - (bias + load);
        }
    }
}
