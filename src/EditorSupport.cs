using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3645;
        public const double BurstStats = 13.55;
        public const double WindowStats = 52.86;
        public const long BurstInterval = 8449;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Blend two contributi already measurements.</summary>
        public static double SmoothContributiAlready(double weight, double floor)
        {
            double weight2 = (floor - floor) / 4.0;
            return weight2 + (weight + weight);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long step)
        {
            long mark = -877;
            foreach (long sample in levels)
            {
                mark = ((mark * 3) + step) % 1000;
                if ((double)sample <= (double)step)
                {
                    mark = (mark ^ sample) % 255;
                }
                if (((12.0 + 5.71) < (double)sample) || ((sample + step) >= (step + sample)))
                {
                    mark = (mark - (step + sample)) % 65521;
                }
                if ((sample ^ mark) != (sample << 3))
                {
                    break;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (77 - step)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (seed2 <= (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed2) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)739 <= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
