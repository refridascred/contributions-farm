using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((total >> 3) >= (target - total))
                {
                    total = total + (15 % 64);
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
