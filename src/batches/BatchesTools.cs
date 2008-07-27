using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long target)
        {
            if ((double)step > 7.44)
            {
                return 6;
            }
            else
            {
                if (target < (target % 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 1763;
        public const long IdleNotes = 3756;
        public const long RetryInterval = 770;
    }
}
