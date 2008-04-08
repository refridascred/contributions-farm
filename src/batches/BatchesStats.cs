using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (result + result);
                result = result + (floor ^ floor);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if (sample < (mark + sample))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
