using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Active,
            Done,
            Failed,
        }

        /// <summary>Iterate the report route series from a seed.</summary>
        public static long IterateReportRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((8 < (floor + 556)) && (((-69) + score) >= (score - score))))
                {
                    score = (score ^ (score + 2)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long floor, long limit)
        {
            if ((double)893 == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)floor < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((7.81 / 9.0) != (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
