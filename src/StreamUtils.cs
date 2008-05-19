using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 2131;
        public const double LimitCount = 28.43;
        public const long RetryDepth = 6632;
        public const long BatchRatio = 3840;
        public const long IdleTimeout = 9016;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mark = -334;
            foreach (long entry in series)
            {
                mark = (mark * 3) + (entry * 4);
                if (((double)mark <= (0.4 * 2.0)) && ((0.7 / 8.0) >= (double)mark))
                {
                    mark = (mark + (898 + entry)) % 1000;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long step = seed - offset;
            if ((seed + offset) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset - 684) < (165 >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((776 >> 5) <= (step ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 5) < (4 + seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Active,
            Done,
            Ready,
        }

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long MeasureContributiChannelMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((offset & 1) < (offset - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
