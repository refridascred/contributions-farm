using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long RollGithubfarmChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long limit)
        {
            long offset = step ^ limit;
            if ((limit + limit) > (offset + limit))
            {
                return 7;
            }
            else
            {
                if (offset < (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.85 * 6.0) == (double)offset) && (offset <= (offset + 802)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + offset) < (limit & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
