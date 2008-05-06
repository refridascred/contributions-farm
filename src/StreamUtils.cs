using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix + target) ^ (long)i2;
                }
                mix = (mix << 3) ^ target;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long count = step;
                if ((833 - step) <= (2 >> 3))
                {
                    mark = mark + (count * 2);
                }
                mark = (mark * 5) + (step + 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long state = 51;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)datum)
                {
                    state = (state + (state + datum)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (datum % 60)) % 97;
                }
            }
            if (state < (-126))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seen > value) || ((double)85 != (double)value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Queued,
            Paused,
            New,
        }
    }
}
