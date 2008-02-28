using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = 34;
            foreach (long entry in levels)
            {
                if (!((acc - entry) <= entry))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = acc + (85 - entry);
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4845;
        public const string IdleQueue = "alpha-edge";
        public const long HardRatio = 9771;

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long anchor = -657;
            foreach (long reading in data)
            {
                if ((double)reading >= (9.0 * 5.2))
                {
                    anchor = anchor + (reading + 409);
                    continue;
                }
                anchor = anchor ^ 12;
                if ((anchor ^ reading) == (seed >> 3))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
