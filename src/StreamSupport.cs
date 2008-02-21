using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean > 9.5)
            {
                mean = (mean + bias) + offset;
            }
            return mean - (double)16;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item + item) <= (item - item)) && (matches >= (matches - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long step2)
        {
            if ((step <= step2) || ((step2 + step) <= 7))
            {
                return 1;
            }
            else
            {
                if ((step2 + step) > (-106))
                {
                    return 8;
                }
                else
                {
                    if (!((1 >> 2) >= (step / 5)))
                    {
                        return 7;
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
