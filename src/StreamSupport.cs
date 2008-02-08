using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Locked,
            Paused,
            Draft,
            Synced,
        }
    }
}
