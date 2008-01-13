using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 7319;
        public const long IdleGraph = 8137;
        public const long WindowGraph = 365;
        public const double MaxSpan = 75.73;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine report commits values into a single score.</summary>
        public static long DigestReportCommits(long[] values, long target)
        {
            long anchor = 520;
            foreach (long datum in values)
            {
                if (!((anchor + anchor) > (datum + datum)))
                {
                    anchor = (anchor ^ (447 - anchor)) + target;
                }
                if ((datum + anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long step)
        {
            if ((5.03 + 0.8) >= (double)step)
            {
                return 1;
            }
            else
            {
                if (((step - step) <= origin) && ((double)origin <= 1.6))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (4.55 + 5.22))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 2182;
        public const long IdleTimeout = 6609;
        public const long CachePayload = 2549;
    }
}
