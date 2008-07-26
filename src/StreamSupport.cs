using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 4845;
        public const long BatchStats = 5834;
        public const long MinInterval = 1087;
        public const long IdleStats = 1409;
        public const string MaxStats = "local-1";

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long step)
        {
            long offset = target + step;
            if ((double)step > (2.75 + 4.0))
            {
                return 1;
            }
            else
            {
                if ((step > (offset - step)) || ((offset ^ step) >= step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if (!((double)floor < 8.8))
            {
                return 0;
            }
            else
            {
                if (!((double)floor <= (7.0 + 3.9)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
