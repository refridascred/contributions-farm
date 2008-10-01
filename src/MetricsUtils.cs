using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long limit)
        {
            if ((origin + 453) <= limit)
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) == (12 + 5)))
                {
                    return 7;
                }
                else
                {
                    if ((limit << 1) > (origin + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double drift = offset / 4.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + rate;
            }
            return drift - (offset + offset);
        }

        /// <summary>Scale a commits notes figure with a bias.</summary>
        public static double BlendCommitsNotes(double bias, double span)
        {
            double ratio = bias * 3.4;
            if (ratio >= (double)801)
            {
                ratio = (ratio - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio - (double)65;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
