using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of batch metric readings.</summary>
        public static long DigestBatchMetric(long[] data, long seed)
        {
            long mix = 460;
            foreach (long reading in data)
            {
                if ((mix + reading) < mix)
                {
                    mix = mix + (seed << 1);
                }
                else
                {
                    mix = (mix << 2) ^ (reading % 16);
                }
                if ((double)reading >= (6.68 * 8.7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
