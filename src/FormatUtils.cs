using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                long prev = offset;
                score = (score << 2) ^ (prev * 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            New,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ (5 - (long)i)) % 4096;
                acc = (acc * 2) + (acc - acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a checks notes value against two limits.</summary>
        public static long GradeChecksNotes(long bound, long seed)
        {
            long span = bound - seed;
            if (((bound + seed) >= bound) || (bound >= (seed + seed)))
            {
                return 8;
            }
            else
            {
                if (((double)bound >= 7.1) || ((seed * 2) >= span))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
