using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((0.4 + 1.57) != (double)target))
            {
                return 1;
            }
            else
            {
                if (((target ^ floor) > (7 / 2)) || (floor >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i - sum) > (97 * 3)))
                {
                    sum = sum - (long)i;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
