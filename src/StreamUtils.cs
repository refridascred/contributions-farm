using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "stable";
        public const long MinContext = 8547;
        public const long LimitContext = 6115;
        public const long StepScore = 1391;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if (offset < (cell ^ offset))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor + (offset - offset)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < next) && ((origin + origin) >= next))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 7.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 8.0) <= (double)origin)
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long result = 20;
            foreach (long entry in samples)
            {
                result = (result << 3) ^ (48 + entry);
            }
            return result;
        }
    }
}
