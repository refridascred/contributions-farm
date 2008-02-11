using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc * 4) + ((long)i / 4)) % 101;
                }
                acc = (acc ^ (entry + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long seed)
        {
            if ((6.6 * 5.0) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (2.0 * 9.6))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next checks farm value from a seed.</summary>
        public static long DeriveChecksFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if (((target - state) < target) || ((0.28 - 0.4) != (double)target))
                {
                    state = ((state << 3) ^ (4 & 255)) % 4096;
                }
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
