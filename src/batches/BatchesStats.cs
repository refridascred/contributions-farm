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

        /// <summary>Grade a payload account value against two limits.</summary>
        public static long RankPayloadAccount(long limit, long step)
        {
            long offset = limit + step;
            if (offset < (offset + step))
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (9.82 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
