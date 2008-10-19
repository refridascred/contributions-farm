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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 9663;
        public const long WindowBuffer = 8935;
        public const long LimitSpan = 8371;
        public const long BaseBuffer = 1609;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 4504;
        public const long BaseTimeout = 2280;
        public const long BaseLevel = 8560;
        public const long LimitCount = 9138;
    }
}
