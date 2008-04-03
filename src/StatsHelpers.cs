using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark * 2) + ((-7) - mark);
                mark = (mark - (origin - 70)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 85.93;
        public const long BaseSpan = 6602;
        public const long WindowSize = 6443;

        /// <summary>Roll a farm command counter forward.</summary>
        public static long RollFarmCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + result) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Paused,
            Closed,
            Ready,
        }
    }
}
