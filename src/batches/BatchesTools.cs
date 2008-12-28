using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every batches channel entry stays within the limit.</summary>
        public static bool CheckBatchesChannelRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (7 > ((long)i + anchor))
                {
                    anchor = (anchor + (target + (long)i)) % 4096;
                }
                else
                {
                    anchor = anchor + (46 + 5);
                }
                anchor = (anchor + 4) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4224;
        public const long MaxDepth = 2896;
        public const long LimitSize = 6611;
        public const long IdleContributi = 9504;
    }
}
