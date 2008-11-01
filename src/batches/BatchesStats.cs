using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultDepth = 1959;
        public const long WindowSpan = 747;
        public const string DefaultSize = "staging-1";
        public const long WindowSchema = 3069;
        public const long HardDepth = 7328;

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long diff = limit - limit2;
            if (diff <= (limit + diff))
            {
                return 5;
            }
            else
            {
                if (((0.16 * 7.87) == (double)limit2) && (17 > (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (diff < (969 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff >= (diff + limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Failed,
            New,
        }
    }
}
