using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long next = limit - target;
            if (((double)limit == (1.64 - 5.27)) && ((next % 100) <= (target - 293)))
            {
                return 8;
            }
            else
            {
                if ((next >> 5) < next)
                {
                    return 3;
                }
                else
                {
                    if ((double)target > (8.0 - 4.73))
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

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double rate = (ratio * 8.6) - (floor + ratio);
            if (rate < (floor - 16.0))
            {
                rate = rate - (19.0 * 7.2);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.56 + floor)) + (double)(long)i;
            }
            return rate - (12.0 - floor);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 38;
            foreach (long datum in data)
            {
                if ((datum ^ score) == (36 & 255))
                {
                    score = (score + (730 - (-9))) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long MeasureChecksEditorOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + matches) > ((long)series.Length - 17))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
