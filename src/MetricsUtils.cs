using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long TallyCounterNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) <= ((long)series.Length >> 1))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples)
        {
            long score = -943;
            foreach (long cell in samples)
            {
                score = ((score ^ (score / 9)) % 101) ^ cell;
            }
            if (score > 7)
            {
                score = score + (long)samples.Length;
            }
            return score;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
