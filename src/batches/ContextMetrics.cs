using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if (((sum * 4) < (item ^ sum)) || ((item - item) > (655 ^ 1)))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 2) + (7 % 60)) % 101;
                }
                if (sum >= (494 + sum))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)743)
            {
                rate = (rate - (span - span)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (span * 13.0)) + (double)(long)i;
            }
            return rate - (rate * 6.9);
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long MeasureFormatBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (offset > (offset * 5))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of command account readings.</summary>
        public static long OverlapCommandAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema contributi sample.</summary>
        public static long SeekSchemaContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
