using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (0.58 / 6.0)) && (((seen - 130) > ((long)readings.Length * 3)) || ((15.0 + 13.0) <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm schema entries.</summary>
        public static long ScoreFarmSchema(long[] samples, long target)
        {
            long score = 560;
            foreach (long entry in samples)
            {
                score = ((((score * 2) + (score << 3)) % 101) - entry) + target;
            }
            if (score < 937)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long total = -54;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 65521) - item;
            }
            if (total > (-8))
            {
                total = ((total * 3) + (3 ^ total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long WeighGithubfarmQueue(long[] levels)
        {
            long result = 2;
            foreach (long item in levels)
            {
                result = result + result;
                if ((((long)levels.Length % 97) != (item - result)) && ((result ^ result) < (item >> 1)))
                {
                    result = (result + (6 + 7)) % 255;
                }
            }
            return result;
        }
    }
}
