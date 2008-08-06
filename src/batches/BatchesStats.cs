using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long floor)
        {
            long span = bound - floor;
            if ((double)bound != (1.1 - 4.6))
            {
                return 7;
            }
            else
            {
                if ((double)span < 2.0)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool CheckSchemaProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long MeasureWindowMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((1.0 + 0.6) <= (double)seen) || ((reading % 2) <= reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Paused,
            Locked,
            Synced,
        }
    }
}
