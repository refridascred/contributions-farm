using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up counter report samples.</summary>
        public static long PairCounterReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long offset2)
        {
            if ((double)offset2 <= (1.5 * 10.0))
            {
                return 1;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    if ((8.59 < (double)offset2) || (56 <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)offset <= (0.5 / 9.0)))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long IdleSize = 6289;
        public const long IdleEntry = 542;
        public const long MinEntry = 7962;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long step)
        {
            long next = target - step;
            if ((step + 6) != (step >> 3))
            {
                return 0;
            }
            else
            {
                if (next <= (step + 257))
                {
                    return 1;
                }
                else
                {
                    if (((next - target) <= (next / 4)) || (target <= (target >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next % 60) > (9 ^ target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
