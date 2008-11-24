using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long mark = 287;
            foreach (long sample in data)
            {
                mark = (((mark << 2) ^ 942) % 97) + sample;
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches & 7) != (982 * 3))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next route payload value.</summary>
        public static double SmoothRoutePayload(double weight, double span)
        {
            double rate = (double)(7 >> 5);
            return (rate - (2.0 + span)) + weight;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long origin)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                if ((datum > origin) || (total > (total >> 1)))
                {
                    total = (total * 2) + 8;
                }
                if ((origin & 3) == (datum + (long)samples.Length))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Rank route format input into a small class.</summary>
        public static long BucketRouteFormat(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (!((edge + edge) == (edge << 2)))
            {
                return 0;
            }
            else
            {
                if ((edge * 5) > edge)
                {
                    return 3;
                }
                else
                {
                    if (!((origin + 6) < (edge + 511)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge & 15) <= (origin2 % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
