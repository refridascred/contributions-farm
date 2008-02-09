using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long score = -56;
            foreach (long datum in items)
            {
                long seen = (datum - 3) - (datum ^ datum);
                score = score ^ ((long)items.Length + seen);
                if ((9 ^ score) == (datum + datum))
                {
                    score = score ^ datum;
                }
            }
            return score;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double mean = floor + (floor * 4.0);
            if (mean <= floor)
            {
                mean = mean + (double)94;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio / 9.0)) - (double)(long)i;
            }
            return mean + (17.0 - ratio);
        }

        /// <summary>Measure how many contributi metrics samples are out of range.</summary>
        public static long TallyContributiMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (1.13 - 18.0))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
