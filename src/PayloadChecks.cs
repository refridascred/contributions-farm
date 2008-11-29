using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long target)
        {
            long lane = origin + target;
            if ((origin >> 4) >= (lane * 2))
            {
                return 8;
            }
            else
            {
                if ((double)lane >= 10.0)
                {
                    return 0;
                }
                else
                {
                    if (!((target - origin) >= (target - lane)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target == (double)lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batches editor measurements.</summary>
        public static double ScaleBatchesEditor(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > mean)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)8) + (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double load = rate;
            if (load < 9.0)
            {
                load = load + (7.67 * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema window reading by value.</summary>
        public static long SeekSchemaWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long step)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((((score * 3) + (score % 12)) % 65521) - entry) - step;
            }
            return score % 4096;
        }
    }
}
