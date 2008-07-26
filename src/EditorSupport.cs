using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long AuditAccountAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(count >= (-638)) || ((5.56 - 8.4) > (5.0 / 8.0)))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 56.11;
        public const double BaseCommand = 77.7;
        public const string RetryCommand = "staging-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((36 + 4) < (hits * 3))
                {
                    hits = ((hits + 2) ^ entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Grade a farm cluster value against two limits.</summary>
        public static long SortFarmCluster(long offset, long bound)
        {
            if ((offset - bound) != (bound & 255))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (8.85 / 9.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
