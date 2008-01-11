using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double weight = (rate / 3.0) - 4.75;
            if (weight < rate)
            {
                weight = (weight + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (double)877;
        }

        /// <summary>Compare every pair of account order readings.</summary>
        public static long CompareAccountOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long AuditRouteBatchesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.5 + 4.2) == (double)matches) && (4.1 > (double)cell))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = 2.29;
            if (mean > mean)
            {
                mean = (mean - (mean - mean)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean + 16.0;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
