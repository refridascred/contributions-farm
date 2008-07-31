using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next githubfarm metrics value from a seed.</summary>
        public static long StepGithubfarmMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((total - (long)i) >= (total + 15)) && (limit > (limit - (long)i)))
                {
                    continue;
                }
                else
                {
                    total = (total - ((long)i + limit)) % 1000;
                }
                total = total - (49 << 3);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 2) + (total + limit)) % 255) ^ (long)i2;
                    total = total ^ (long)i;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Locked,
            Synced,
        }
    }
}
