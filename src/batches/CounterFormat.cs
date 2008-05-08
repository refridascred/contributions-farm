using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum + sum) * 4;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum ^ (delta << 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
