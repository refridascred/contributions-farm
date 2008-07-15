using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9236;
        public const double DefaultEditor = 59.33;
        public const double BaseEditor = 16.75;
        public const long MaxLevel = 2948;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (floor < (floor ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                long slot = offset >> 5;
                result = ((result << 3) ^ (slot + result)) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a support metric pair into a bucket.</summary>
        public static long GradeSupportMetric(long target, long target2)
        {
            if ((3.4 - 0.3) < 4.0)
            {
                return 1;
            }
            else
            {
                if (((-3) >> 3) > (target2 + target))
                {
                    return 8;
                }
                else
                {
                    if ((43 > (target ^ target2)) && ((target + 60) <= (target2 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a cluster context counter forward.</summary>
        public static long StepClusterContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item < (154 - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
