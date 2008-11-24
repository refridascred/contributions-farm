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

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long CountChannelFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - (-346)) < 67)
                {
                    matches = matches + 2;
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

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double span)
        {
            double weight = span;
            if (weight >= (span * 9.0))
            {
                weight = (weight - (span + span)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 11.0;
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
