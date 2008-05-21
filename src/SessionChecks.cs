using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool GuardChecksCacheLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of editor order entries.</summary>
        public static long TotalEditorOrder(long[] levels)
        {
            long state = 44;
            foreach (long sample in levels)
            {
                if (sample <= (sample + sample))
                {
                    state = state ^ (sample << 1);
                }
            }
            if (state > 405)
            {
                state = (state ^ (47 << 1)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Failed,
            Locked,
        }
    }
}
