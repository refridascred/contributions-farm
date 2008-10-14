using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long acc = 887;
            foreach (long value in samples)
            {
                if ((acc / 4) == (acc ^ value))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (65 + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long CountChecksFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ matches) > 912)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)bound != (4.0 / 5.0))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            if ((double)limit < (7.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if (!(offset <= limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
