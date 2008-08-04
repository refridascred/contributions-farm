using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value + tally) > (tally - value)) && (((-2) ^ tally) > tally)) && ((double)(long)values.Length >= (5.48 + 3.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record support figure with a bias.</summary>
        public static double ProjectRecordSupport(double ratio, double floor)
        {
            double bias = ratio * 4.81;
            if (bias >= floor)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (bias - bias);
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 5761;
        public const string DefaultMetrics = "local-edge";
        public const long BaseLevel = 7460;
        public const string BurstMetrics = "alpha-v2";

        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool CheckCounterNotesBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
