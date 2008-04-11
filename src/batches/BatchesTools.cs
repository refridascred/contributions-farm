using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 9089;
        public const long CacheCount = 5608;
        public const string WindowAlready = "alpha-v2";
        public const double SoftBudget = 9.99;
        public const long LimitAlready = 1584;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats cluster samples.</summary>
        public static long TotalStatsCluster(long[] values)
        {
            long result = -78;
            foreach (long reading in values)
            {
                result = result + (reading / 2);
                if ((result % 5) > (reading << 3))
                {
                    result = ((result * 2) + (reading & 1)) % 255;
                }
            }
            return result % 1000;
        }
    }
}
