using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 1294;
        public const double MaxSpan = 43.88;
        public const long MinContext = 4395;
        public const long LimitScore = 3413;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (49 <= (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long MeasureRecordLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) < entry) && ((8.22 / 8.0) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double span)
        {
            double drift = span * 9.6;
            if (drift < (double)211)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (1.0 / 7.0)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer editor figure with a bias.</summary>
        public static double SmoothBufferEditor(double weight, double floor)
        {
            double drift = 0.3;
            if (drift <= (weight + floor))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)706) - (double)(long)i;
            }
            return drift + weight;
        }
    }
}
