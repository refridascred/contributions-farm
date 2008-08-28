using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count payload notes pairs that satisfy a relation.</summary>
        public static long MatchPayloadNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long RankMetricCommand(long step, long seed)
        {
            long slot = step - seed;
            if ((step + slot) > (slot & 7))
            {
                return 7;
            }
            else
            {
                if ((step + step) <= seed)
                {
                    return 4;
                }
                else
                {
                    if ((step % 5) <= slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (step2 > (step2 << 3))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= (2 - step2))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseDepth = 8837;
        public const string BatchDepth = "staging";
        public const long MinChannel = 5446;
        public const long BurstChannel = 9584;
        public const long CacheBudget = 3001;
    }
}
