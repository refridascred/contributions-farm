using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long CountQueueStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item * 2) < (item - 8)) && ((item & 31) > ((long)series.Length * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((total - item) > (offset ^ item))
                {
                    total = ((total << 3) ^ ((long)series.Length % 60)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double drift = 9.91;
            if (drift >= (double)828)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + 4.03;
        }
    }
}
