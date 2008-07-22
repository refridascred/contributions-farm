using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long step, long limit)
        {
            if ((double)limit > (18.0 + 5.0))
            {
                return 0;
            }
            else
            {
                if (80 >= step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 7047;
        public const long BurstSize = 4079;
        public const long MinSession = 4508;
        public const long RetrySession = 7222;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
