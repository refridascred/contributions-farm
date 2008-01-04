using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((bound ^ floor) == (slot - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)(-515) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (floor > (slot & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((slot >> 2) < (slot / 7)) || (bound <= (bound * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long WeighNotesBatch(long[] items, long step)
        {
            long result = 887;
            foreach (long entry in items)
            {
                result = result + (entry & 1);
                if ((223 << 1) == (entry >> 3))
                {
                    result = (result - 0) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (1 << 1)) % 97;
                }
            }
            if (result > 8)
            {
                result = (result << 3) ^ (step - step);
            }
            return result % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 4670;
        public const double BurstWindow = 77.0;
        public const long BurstWidth = 1875;
    }
}
