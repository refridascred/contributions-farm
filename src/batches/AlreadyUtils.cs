using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step + step) < (offset >> 1))
            {
                return 7;
            }
            else
            {
                if (((53 << 1) < (offset - 1)) || ((4.0 - 5.9) > (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((offset + step) > 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >= (offset & 1)) || ((9.18 / 2.0) > (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry ^ 77) + reading;
            }
            if (carry < 6)
            {
                carry = (carry + (carry - 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((800 + hits) == (hits / 9)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Synced,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
