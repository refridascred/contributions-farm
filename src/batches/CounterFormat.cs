using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue tools samples.</summary>
        public static long TallyQueueTools(long[] samples, long target)
        {
            long total = 775;
            foreach (long cell in samples)
            {
                total = (total << 3) ^ 422;
                if (target < (cell - total))
                {
                    total = (total ^ (target % 7)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.0 + 4.7) > (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
