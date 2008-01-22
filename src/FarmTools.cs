using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long floor)
        {
            long delta = offset + floor;
            if ((5.25 / 7.0) < (double)floor)
            {
                return 6;
            }
            else
            {
                if ((offset + delta) >= (floor / 8))
                {
                    return 1;
                }
                else
                {
                    if ((delta & 1) < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor < 1.81))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long bound)
        {
            long result = 15;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result << 2) ^ ((long)i / 9)) - bound;
                    result = ((result << 3) ^ (788 % 10)) % 4096;
                }
                if (!(45 >= (entry ^ entry)))
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }
    }
}
