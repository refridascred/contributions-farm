using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long SeriesSessionGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total >= (total - (long)i)) || ((limit / 9) > 5))
                {
                    total = total ^ limit;
                    total = (total + total) % 97;
                }
                if (6 >= (limit ^ (long)i))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = ((total * 5) + (limit + 0)) % 255;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if ((double)seed > (1.0 * 9.0))
            {
                return 3;
            }
            else
            {
                if ((seed * 5) != (step - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            New,
            Dropped,
            Synced,
            Stale,
        }
    }
}
