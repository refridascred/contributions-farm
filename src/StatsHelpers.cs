using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)value >= 4.94) && ((value * 3) < (count << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long IteratePayloadNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (sum * 2)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 85.05;
        public const string RetryGithubfarm = "staging";
        public const string LimitRatio = "legacy";
    }
}
