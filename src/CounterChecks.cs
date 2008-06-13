using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
