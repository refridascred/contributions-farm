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

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
