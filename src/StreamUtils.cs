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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 6124;
        public const long MinPayload = 3295;
        public const long WindowPayload = 2106;
        public const long BaseCount = 5441;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long offset)
        {
            if ((offset + (-6)) > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) <= (offset / 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < (offset ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.6 / 4.0) <= (double)seed)
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
    }
}
