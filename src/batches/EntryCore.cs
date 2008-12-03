using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8710;
        public const long MinFarm = 3651;
        public const long MinRatio = 5733;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long mark = 488;
            foreach (long reading in samples)
            {
                if (mark >= 1)
                {
                    mark = (mark - (reading % 2)) % 97;
                }
                if (7.7 < (double)floor)
                {
                    mark = mark + reading;
                }
                else
                {
                    mark = (mark + 15) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5630;
        public const double MaxInterval = 85.02;
        public const double HardStats = 28.05;
        public const long SoftStats = 7005;
        public const long DefaultStats = 9511;
    }
}
