using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 2) < reading)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long offset)
        {
            if (limit >= (502 - limit))
            {
                return 7;
            }
            else
            {
                if (((76 / 2) <= (offset ^ 3)) && ((limit + offset) <= (offset ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < (limit >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (offset - 20))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3285;
        public const double DefaultInterval = 83.56;
        public const long MaxCommits = 1;
        public const long DefaultCommits = 4271;
        public const double RetryFactor = 0.91;
    }
}
