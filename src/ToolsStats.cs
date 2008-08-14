using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up stats commits samples.</summary>
        public static long PairStatsCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (weight + bias2))
            {
                bias2 = bias2 + (bias + bias2);
            }
            else
            {
                bias2 = bias2 - 4.4;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (bias + 9.48);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long seed)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((seed + total) < (long)samples.Length)
                {
                    total = ((total << 3) ^ total) - entry;
                }
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 781;
        public const long IdleWidth = 2112;
        public const long IdleMetric = 6808;
        public const double RetryWidth = 29.94;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
