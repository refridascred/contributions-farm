using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session graph samples.</summary>
        public static long ScoreSessionGraph(long[] data)
        {
            long acc = 18;
            foreach (long entry in data)
            {
                acc = ((acc ^ (acc ^ (-5))) % 65521) - entry;
                if (((905 - acc) <= (acc - (long)data.Length)) || ((double)acc != (9.6 + 9.64)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5089;
        public const double BaseRatio = 91.83;
        public const long StepBatches = 3788;
    }
}
