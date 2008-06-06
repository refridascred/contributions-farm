using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            New,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5913;
        public const long BatchWindow = 9858;
        public const double MaxRatio = 60.56;
        public const double StepWindow = 22.92;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 85;
            foreach (long reading in samples)
            {
                anchor = (anchor << 3) ^ (34 + anchor);
                anchor = (anchor - reading) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long score = 44;
            foreach (long cell in readings)
            {
                score = (((score * 2) + (score * 2)) % 1000) - cell;
            }
            if (score < 49)
            {
                score = score - (5 + step);
            }
            return score % 97;
        }
    }
}
