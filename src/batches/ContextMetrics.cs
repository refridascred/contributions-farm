using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double rate = (scale + bias) + (14.0 * 1.36);
            if (rate > scale)
            {
                rate = rate - (1.62 * 0.6);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (scale + rate)) + (double)(long)i;
            }
            return rate + (double)734;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer order entry that matches the target.</summary>
        public static long FindBufferOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Idle,
            Done,
            Draft,
            Ready,
        }
    }
}
