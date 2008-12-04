using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long CountCommitsClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen & 7) != (seen & 15))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long GradeRecordCounter(long origin, long bound)
        {
            if ((17.0 * 8.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((19.0 + 10.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 6640;
        public const long SoftStream = 7795;
        public const long BaseStream = 4695;
    }
}
