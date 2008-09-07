using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] series)
        {
            long mark = 42;
            foreach (long cell in series)
            {
                if ((653 - cell) < mark)
                {
                    mark = ((mark * 3) + (429 >> 1)) % 255;
                }
                else
                {
                    mark = mark ^ (74 << 2);
                }
                if (((mark + cell) > (mark + mark)) && ((741 >> 5) >= cell))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((96 * 4) <= (sample + (long)data.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8183;
        public const long RetryFactor = 8406;
        public const string RetryInterval = "open-v2";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
