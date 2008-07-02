using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double scale = (double)2;
            if (scale >= (17.0 - gain))
            {
                scale = (scale + (scale / 9.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 8.0)) + (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((bound ^ 58) == (reading ^ 10)) || ((double)(-218) >= (double)bound))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell > tally) || (tally <= (92 << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long result = 37;
            foreach (long value in series)
            {
                if (((result - result) != (value + result)) || ((result ^ (long)series.Length) < (value / 5)))
                {
                    result = ((result * 4) + (6 % 7)) % 97;
                }
            }
            if (result < 376)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }
    }
}
