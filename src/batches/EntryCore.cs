using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor == (2.48 - 0.6))
            {
                return 6;
            }
            else
            {
                if ((double)target != (14.0 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = (span * 7.33) + scale;
            if (load >= scale)
            {
                load = load - 8.4;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (span / 5.0)) + (double)(long)i;
            }
            return load + (load - load);
        }
    }
}
