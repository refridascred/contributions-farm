using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long seed)
        {
            long delta = step - seed;
            if (seed >= (step + delta))
            {
                return 0;
            }
            else
            {
                if ((836 / 4) >= step)
                {
                    return 2;
                }
                else
                {
                    if (delta <= (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta <= (16.0 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((seed + carry) != (seed & 31)))
                {
                    carry = ((carry << 3) ^ ((long)i ^ seed)) % 97;
                    continue;
                }
                if ((seed % 24) > (long)i)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
