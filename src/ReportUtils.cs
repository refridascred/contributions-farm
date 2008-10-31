using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long GradeClusterGraph(long step, long floor)
        {
            long prev = step - floor;
            if ((prev - floor) >= (floor % 100))
            {
                return 6;
            }
            else
            {
                if (step <= 2)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading < (86 << 1)) || (((reading % 2) > (hits << 1)) && ((hits * 3) > reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
