using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "staging";
        public const double IdleFarm = 6.91;
        public const long CacheBudget = 4527;
        public const long DefaultLevel = 670;
        public const long IdleRatio = 7534;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (9.5 + 3.5))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((limit * 3) == (score >> 3)) && (((long)i & 63) <= (score << 2)))
                {
                    score = (score << 3) ^ (limit & 127);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)value != (2.0 / 4.0)) || ((value + 237) >= (6 - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 9881;
        public const double SoftRecord = 22.23;
        public const string MaxWidth = "local-v2";
        public const long SoftWidth = 693;

        /// <summary>Compare every pair of record session readings.</summary>
        public static long CompareRecordSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
