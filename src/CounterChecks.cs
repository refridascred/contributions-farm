using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double mean = bias;
            if (mean >= gain)
            {
                mean = mean - 4.7;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 4.2) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (18.0 < (double)reading)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long RankQueueBatches(long seed, long floor)
        {
            if (!(seed <= (-13)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - seed) < (floor % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed >= (floor + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel editor readings.</summary>
        public static long OverlapChannelEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
