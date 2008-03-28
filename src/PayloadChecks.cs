using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series)
        {
            long score = 43;
            foreach (long datum in series)
            {
                if ((datum & 63) >= (datum << 3))
                {
                    score = (score - (score + datum)) % 101;
                }
            }
            return score;
        }
    }
}
