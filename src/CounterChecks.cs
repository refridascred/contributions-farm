using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample & 3) == (95 * 5))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits >= ((-52) % 97))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double gain = 10.0;
            if (gain >= weight)
            {
                gain = (gain - (double)64) - offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + gain)) + (double)(long)i;
            }
            return gain + (double)3;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = (sum - sample) % 255;
                sum = (sum ^ sum) % 255;
            }
            if (sum < 5)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
