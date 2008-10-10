using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up queue commits samples.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long origin)
        {
            if ((step & 1) <= (1 + step))
            {
                return 0;
            }
            else
            {
                if ((step >= (step % 3)) || ((step - step) != (step >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin - step) < (origin % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1539;
        public const double BatchFormat = 54.94;
        public const double MinFormat = 93.69;
        public const long BaseBudget = 3219;
        public const long IdleDepth = 6557;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
