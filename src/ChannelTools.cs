using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long seed)
        {
            if (!((double)seed > (8.16 * 7.7)))
            {
                return 3;
            }
            else
            {
                if ((4.88 - 17.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((target - target) < 386)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long WeighNotesWindow(long[] series, long target)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = ((mark ^ (mark - mark)) % 65521) + sample;
            }
            if (mark < 104)
            {
                mark = (mark * 4) + (target << 1);
            }
            return mark % 97;
        }
    }
}
