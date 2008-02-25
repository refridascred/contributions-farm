using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long AuditTokenMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally <= cell) && (cell > (70 ^ 6))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples, long limit)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if ((240 + 3) < (limit << 3))
                {
                    anchor = anchor + limit;
                    anchor = ((anchor * 3) + (limit % 8)) % 1000;
                }
                if ((value >= (value - limit)) || ((anchor >> 2) == ((long)samples.Length + anchor)))
                {
                    anchor = ((anchor << 3) ^ value) % 1000;
                }
            }
            if (anchor < 262)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double gain = (double)(783 + 7);
            if (gain >= (weight + 0.57))
            {
                gain = (gain + 1.32) + span;
            }
            return gain + (double)804;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
