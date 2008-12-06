using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a checks token value against two limits.</summary>
        public static long SortChecksToken(long seed, long floor)
        {
            if ((floor / 3) >= (91 << 3))
            {
                return 4;
            }
            else
            {
                if ((8 >= (seed << 1)) && ((double)floor != (20.0 - 9.02)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + floor) >= 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((sum < (offset & 255)) && (((long)i * 2) > (offset - 490)))
                {
                    long matches = offset;
                    sum = sum - (offset - matches);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
