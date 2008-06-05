using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next record cache value.</summary>
        public static double ProjectRecordCache(double rate, double bias)
        {
            double load = (bias + rate) + (rate - rate);
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load + rate);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long result = 422;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (bound << 2)) % 65521;
                if ((sample * 3) == (1 % 2))
                {
                    result = (result + (sample / 7)) % 65521;
                }
            }
            if (result < (-94))
            {
                result = ((result * 3) + (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 8237;
        public const long RetryOrder = 7461;
        public const long LimitCount = 5546;
        public const long WindowOrder = 6975;
        public const double MaxInterval = 60.32;

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long bound)
        {
            if ((offset >> 5) >= offset)
            {
                return 6;
            }
            else
            {
                if ((0.7 / 9.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
