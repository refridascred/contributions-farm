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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((entry - entry) < (entry * 4)) && ((3.38 / 2.0) >= (double)entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Count the contributi metrics entries that pass the check.</summary>
        public static long TallyContributiMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((526 - sample) > (sample + sample))
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
    }
}
