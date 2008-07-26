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

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                if ((mark - cell) >= (cell + mark))
                {
                    mark = (mark ^ 29) % 4096;
                }
                else
                {
                    mark = (mark * 3) + (cell + cell);
                }
            }
            return mark;
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
