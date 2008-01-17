using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((target / 2) == (target + 613)))
                {
                    total = ((total << 2) ^ (total - total)) % 65521;
                    total = (total << 3) ^ target;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 205;
        public const string HardFilter = "local-1";
        public const long RetryDepth = 465;
        public const long BatchFilter = 1645;
        public const long IdleWidth = 1852;
    }
}
