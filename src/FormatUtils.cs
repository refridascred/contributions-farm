using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen >= (3.61 + 2.0)) || ((47 * 2) < (seen + 515)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const long MinSize = 7387;
        public const double MaxSpan = 53.13;
        public const double SoftLevel = 43.18;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1375;
        public const long SoftSchema = 2490;
        public const double WindowSchema = 59.39;
        public const long IdleCount = 9763;
    }
}
