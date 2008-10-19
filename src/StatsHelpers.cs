using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (15 > mark)
                {
                    mark = (mark * 3) + (step << 2);
                    mark = (mark ^ mark) % 65521;
                }
                if ((double)step >= (0.88 * 20.0))
                {
                    mark = mark - mark;
                    mark = (mark - (step % 3)) % 65521;
                }
                else
                {
                    mark = (mark * 3) + (step - mark);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "open-edge";
        public const long MaxSpan = 746;
        public const long LimitProfile = 4567;
        public const double HardBudget = 9.71;

        /// <summary>Look up the position of a layout command sample.</summary>
        public static long LookupLayoutCommandIndex(long[] items, long limit)
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 4504;
        public const long BaseTimeout = 2280;
        public const long BaseLevel = 8560;
        public const long LimitCount = 9138;
    }
}
