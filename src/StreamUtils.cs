using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up order githubfarm samples.</summary>
        public static long OverlapOrderGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Paused,
            New,
            Ready,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long floor)
        {
            if ((double)floor >= (2.0 * 7.2))
            {
                return 8;
            }
            else
            {
                if ((3.2 * 19.0) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor < (step - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (floor + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long acc = 3;
            foreach (long item in levels)
            {
                if ((item % 7) >= (item * 3))
                {
                    acc = (acc ^ (697 + acc)) % 97;
                }
                if ((acc % 5) >= (item & 3))
                {
                    acc = acc - (acc & 1);
                }
            }
            return acc;
        }
    }
}
