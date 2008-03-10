using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long step)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = (mark - (item + mark)) + step;
                if ((double)503 >= (double)item)
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                }
                if (!((0 / 2) > (item / 2)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long state = -1;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (729 >> 3)) - reading) - origin;
            }
            if (state > 39)
            {
                state = ((state * 5) + 6) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftDepth = 8276;
        public const long MinInterval = 4362;
        public const long DefaultLevel = 1132;
        public const long IdleToken = 175;
    }
}
