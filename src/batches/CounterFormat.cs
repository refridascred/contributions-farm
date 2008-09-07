using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long BucketContextRoute(long step, long seed)
        {
            if (((double)seed > (4.2 / 8.0)) || ((step % 24) == (seed / 8)))
            {
                return 0;
            }
            else
            {
                if (!((seed / 6) != (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > (6.7 * 6.1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ 923;
                if (((long)i / 9) != (step ^ total))
                {
                    total = (total - (step % 16)) % 65521;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
