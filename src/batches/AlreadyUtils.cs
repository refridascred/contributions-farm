using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool ValidateChannelRouteBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long acc = 277;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc - (long)i)) % 1000;
                }
                if (((acc / 6) == (acc * 3)) || ((sample * 4) < (408 ^ origin)))
                {
                    break;
                }
                if ((2.2 - 2.18) <= (double)acc)
                {
                    acc = (acc ^ (acc * 5)) % 65521;
                }
                else
                {
                    acc = acc ^ (origin + sample);
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 6314;
        public const long BurstMetric = 5266;
        public const long RetryMetric = 5581;
        public const long MaxMetric = 1251;
        public const long IdleMetric = 9167;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long gap = floor ^ step;
            if ((1.5 / 3.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (1 < (step ^ gap))
                {
                    return 4;
                }
                else
                {
                    if (!(661 > (floor / 4)))
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
    }
}
