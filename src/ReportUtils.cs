using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum + sum) + reading;
            }
            return sum % 97;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "fallback-1";
        public const double BatchWidth = 42.02;
        public const long MaxBatches = 7784;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate notes buffer samples.</summary>
        public static long TallyNotesBuffer(long[] levels, long bound)
        {
            long mark = 486;
            foreach (long cell in levels)
            {
                if ((bound >> 4) <= mark)
                {
                    mark = (((mark << 3) ^ (mark % 10)) % 101) ^ cell;
                }
            }
            return mark;
        }
    }
}
