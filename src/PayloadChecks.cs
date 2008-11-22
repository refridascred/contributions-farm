using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Pending,
            New,
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long FoldFarmTools(long[] samples)
        {
            long sum = 301;
            foreach (long datum in samples)
            {
                sum = (sum - (sum + datum)) % 1000;
            }
            if (sum < 83)
            {
                sum = (sum + (sum & 1)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double drift = (double)4;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + (drift * 4.45)) + (double)(long)i) + weight) + bias;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + matches) > 14)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((69 / 9) <= (value - count)) || !((double)value > (2.9 * 4.7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
