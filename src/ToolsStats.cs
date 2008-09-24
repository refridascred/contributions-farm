using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cache support input into a small class.</summary>
        public static long SortCacheSupport(long offset, long floor)
        {
            if ((floor + floor) <= 11)
            {
                return 6;
            }
            else
            {
                if ((double)offset < 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((offset + floor) < (floor & 127))
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Active,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of session cluster readings.</summary>
        public static long CompareSessionClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm report value against two limits.</summary>
        public static long ClassifyGithubfarmReport(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff == (0.51 + 7.56))
            {
                return 7;
            }
            else
            {
                if ((double)diff != (10.0 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (bound > (159 + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
