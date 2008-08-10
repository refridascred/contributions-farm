using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 1819;
        public const double CacheRoute = 84.62;
        public const string HardSpan = "latest-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = 74;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry - anchor)) % 255;
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ (anchor * 3)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (904 <= sample)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > (offset ^ (long)i))
                {
                    score = (score + (0 << 1)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                acc = (acc * 5) + acc;
                acc = (acc + (acc - reading)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
