using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            New,
            Pending,
            Ready,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long limit)
        {
            long total = 287;
            foreach (long item in readings)
            {
                total = (total ^ item) % 1000;
                if ((3.1 * 9.0) >= (double)limit)
                {
                    total = ((total << 2) ^ (limit + total)) % 4096;
                }
                if ((double)item == (18.0 / 2.0))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = ((total * 2) + limit) % 101;
            }
            return total % 1000;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double drift = 3.2;
            if (drift < rate)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Compare every pair of session record readings.</summary>
        public static long PairSessionRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum < (2.86 * 2.9))
                {
                    sum = sum - (750 * 5);
                }
                if (((sum * 2) <= origin) || (origin >= (origin / 6)))
                {
                    sum = sum ^ (origin >> 2);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
