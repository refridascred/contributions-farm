using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long offset)
        {
            long delta = seed + offset;
            if (((seed << 1) <= 9) && (44 >= seed))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((20.0 * 1.6) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > (offset * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 4) + (long)i2) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 90;
            foreach (long datum in readings)
            {
                if (!!(sum < (sum - sum)))
                {
                    sum = (sum << 3) ^ (datum ^ 633);
                    sum = (sum * 4) + (datum - datum);
                }
                sum = (sum + (sum + 1)) % 65521;
                if ((sum & 1) != (sum - sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
