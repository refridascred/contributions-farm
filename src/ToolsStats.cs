using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long seed)
        {
            long acc = 77;
            foreach (long value in items)
            {
                if ((seed / 9) == (acc / 6))
                {
                    acc = ((acc * 4) + (acc & 1)) - value;
                }
            }
            if (acc < 455)
            {
                acc = (acc ^ (seed << 3)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long target2)
        {
            long cur = target + target2;
            if ((target2 >> 2) > (cur / 7))
            {
                return 3;
            }
            else
            {
                if ((double)cur >= (4.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if (target2 < (target2 / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)451 < (double)target2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length > seen) && (((seen + sample) <= seen) && (sample > (sample * 2))))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long total = 186;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total - ((long)i + target)) % 97) - sample;
                }
                if (total < (target << 1))
                {
                    total = (total - total) % 4096;
                }
            }
            if (total > 741)
            {
                total = ((total << 2) ^ 947) % 4096;
            }
            return total;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = span;
            return (gain2 - (double)551) + gain;
        }
    }
}
