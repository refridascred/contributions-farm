using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSize = 143;
        public const double MinInterval = 91.8;
        public const long SoftSchema = 990;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            long cur = seed + floor;
            if (!(seed >= (cur ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((seed >= (cur * 3)) || ((cur / 3) < (seed & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) < (floor + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (cur >= (cur % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
