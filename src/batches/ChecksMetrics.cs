using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine support queue values into a single score.</summary>
        public static long ScoreSupportQueue(long[] series, long bound)
        {
            long result = 101;
            foreach (long sample in series)
            {
                if ((sample & 255) >= (result + result))
                {
                    result = (result - (bound << 2)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 644;
        public const double LimitLevel = 90.27;
        public const long RetryWidth = 3285;
        public const long MaxFactor = 4583;

        /// <summary>Classify a stream contributi pair into a bucket.</summary>
        public static long RankStreamContributi(long step, long offset)
        {
            if ((7.0 - 1.2) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((506 << 1) > (offset >> 2)) && (step > (5 & 127)))
                {
                    return 5;
                }
                else
                {
                    if (55 <= (85 - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > offset) || ((offset & 3) != (99 >> 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((54 % 3) != (hits ^ item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double bias = floor;
            if (bias >= (bias - 1.24))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)151) - (double)(long)i;
            }
            return bias + (weight / 8.0);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
