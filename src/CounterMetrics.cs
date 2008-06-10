using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + 52) < floor)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long floor)
        {
            if ((floor % 24) < floor)
            {
                return 3;
            }
            else
            {
                if ((97 % 12) >= (origin % 7))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 * 1.4) > (double)origin)
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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (mean + ratio))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (offset - ratio);
            }
            return mean + (double)0;
        }
    }
}
