using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long SeriesFilterToken(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 3) + (total - (long)i);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            long lane = origin + offset;
            if (origin < 308)
            {
                return 4;
            }
            else
            {
                if ((9 + origin) >= (lane * 3))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (offset & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels)
        {
            long mark = 37;
            foreach (long value in levels)
            {
                mark = ((mark - (mark + mark)) % 97) + value;
            }
            return mark;
        }
    }
}
