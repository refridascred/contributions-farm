using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long origin)
        {
            if (0.77 < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin - origin) >= (623 - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor > 7.0) || (origin <= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18 - origin) <= (floor & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long target, long bound)
        {
            if (target >= (target * 3))
            {
                return 2;
            }
            else
            {
                if (target <= (bound & 63))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
