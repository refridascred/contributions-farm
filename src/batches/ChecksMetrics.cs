using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (limit & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((sum + sum) >= (sum - seed))
                {
                    sum = sum - seed;
                    sum = (sum * 4) + (60 + sum);
                }
                sum = (sum << 2) ^ (seed << 2);
                sum = (sum + (long)i) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double mean = 8.21;
            if (mean <= floor)
            {
                mean = (mean - (mean + floor)) + gain;
            }
            return mean - (5.0 / 3.0);
        }
    }
}
