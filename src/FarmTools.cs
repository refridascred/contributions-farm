using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = result - ((long)i2 + (long)i);
                }
                if ((result << 2) != (result << 3))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
