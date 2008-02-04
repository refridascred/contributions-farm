using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double load = offset / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + (28 + limit)) % 255;
                sum = (sum << 3) ^ limit;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (acc ^ (entry ^ 99)) - bound;
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((offset <= (sum ^ cell)) && ((cell << 2) >= sum))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = (sum + (offset & 255)) % 4096;
                }
            }
            if (sum < 66)
            {
                sum = sum - (2 * 4);
            }
            return sum % 97;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Dropped,
        }
    }
}
