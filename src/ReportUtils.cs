using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool VerifyContextLayoutRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank window graph input into a small class.</summary>
        public static long RankWindowGraph(long origin, long step)
        {
            long delta = origin - step;
            if ((origin - step) >= (step - origin))
            {
                return 2;
            }
            else
            {
                if ((origin * 4) <= (delta ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((4 > step) || ((step / 7) >= (delta - delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((delta ^ origin) >= (origin * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 79;
            foreach (long sample in readings)
            {
                if ((double)sample > (3.0 * 10.0))
                {
                    long diff = sample;
                    mark = ((mark << 3) ^ (diff - sample)) % 97;
                }
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark - sample)) % 255) ^ (long)i;
                }
                mark = (mark ^ sample) % 4096;
                if (!((double)sample < (1.0 + 6.55)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
