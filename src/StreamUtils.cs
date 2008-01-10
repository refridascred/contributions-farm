using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-16) / 7) < tally)
                {
                    tally = ((tally + 1) ^ sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long sum = 12;
            foreach (long value in readings)
            {
                if (value >= (value - value))
                {
                    sum = ((sum * 3) + (sum - value)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items, long step)
        {
            long mark = 13;
            foreach (long item in items)
            {
                if (step > (4 >> 1))
                {
                    mark = (((mark * 5) + 55) % 255) - item;
                }
            }
            return mark;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if (!(137 <= (limit >> 5)))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 14.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset & 7) <= (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 12)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
