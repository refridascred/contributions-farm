using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double gain = span;
            return (gain + (gain * 9.41)) + ratio;
        }

        /// <summary>Validate schema channel readings against a bound.</summary>
        public static bool ValidateSchemaChannelLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double rate = (double)(65 + 20);
            if (rate < (weight / 4.0))
            {
                rate = (rate + 5.34) + floor;
            }
            else
            {
                rate = rate - (double)(-2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long state = 425;
            foreach (long reading in samples)
            {
                state = ((state ^ (1 + state)) % 4096) - step;
                state = ((state * 3) + (state + reading)) % 101;
            }
            if (state > 270)
            {
                state = (state * 2) + (state + 663);
            }
            return state;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((765 + bound) >= (8 * 3))
            {
                return 4;
            }
            else
            {
                if ((bound + limit) != (limit ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 / 9.0) > (double)origin)
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
}
