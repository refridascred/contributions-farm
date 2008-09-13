using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double rate = bias;
            if (rate < (bias * 19.0))
            {
                rate = (rate - (double)1) - floor;
            }
            return rate + rate;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 3) > (tally + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes support pair into a bucket.</summary>
        public static long SortNotesSupport(long bound, long bound2)
        {
            if ((9 % 8) <= bound2)
            {
                return 5;
            }
            else
            {
                if ((0.6 + 3.0) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (((1.47 / 5.0) != (double)bound2) && ((bound + bound) <= (bound2 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + value) < (matches << 2))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
