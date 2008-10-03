using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate already token readings against a bound.</summary>
        public static bool GuardAlreadyTokenBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long bound)
        {
            long acc = 382;
            foreach (long entry in readings)
            {
                if ((acc << 1) <= 0)
                {
                    acc = (acc + (bound + bound)) % 65521;
                }
                if ((bound <= (entry % 100)) && ((acc & 7) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3955;
        public const string MinCommits = "open-1";
        public const long CacheCommits = 8426;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                mark = (mark + (mark - sample)) % 97;
                if (!((double)sample >= (4.92 * 5.88)))
                {
                    mark = (mark + (sample + (long)readings.Length)) % 101;
                }
                else
                {
                    mark = (mark + sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long CompareChecksAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
