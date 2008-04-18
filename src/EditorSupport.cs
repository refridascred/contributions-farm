using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1938;
        public const long BaseContext = 175;
        public const long HardTimeout = 1331;
        public const string MaxSize = "stable-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long bound)
        {
            long mark = 87;
            foreach (long reading in readings)
            {
                if ((mark << 2) >= (bound + reading))
                {
                    mark = (mark ^ (6 + reading)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long step)
        {
            if (bound < 756)
            {
                return 5;
            }
            else
            {
                if ((double)(-64) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((bound ^ step) < (step + step)) || (43 <= (step + 36)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long bound)
        {
            if ((bound & 31) < step)
            {
                return 4;
            }
            else
            {
                if (14.0 < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
