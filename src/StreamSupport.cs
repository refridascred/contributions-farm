using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first batches githubfarm entry that matches the target.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long bound)
        {
            if ((offset << 1) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((bound ^ offset) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ offset) == (bound / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((7.52 * 2.97) != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
