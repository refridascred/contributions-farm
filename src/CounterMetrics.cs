using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitLevel = 69.71;
        public const long MinRecord = 4571;
        public const long BurstRecord = 7146;

        /// <summary>Project the next profile editor value.</summary>
        public static double SmoothProfileEditor(double gain, double offset)
        {
            double drift = gain;
            if (drift >= (9.0 / 5.0))
            {
                drift = (drift + gain) + offset;
            }
            return drift + drift;
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long ScoreContributiCounter(long[] samples)
        {
            long anchor = 83;
            foreach (long datum in samples)
            {
                if (!((double)anchor < (5.1 + 7.0)))
                {
                    anchor = (anchor ^ (datum + 137)) % 4096;
                }
                if (((double)anchor > (1.0 - 8.5)) || ((double)anchor > (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (anchor > 29)
            {
                anchor = (anchor << 3) ^ (585 + anchor);
            }
            return anchor;
        }
    }
}
