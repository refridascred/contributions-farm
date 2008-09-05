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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen * 4) != (entry << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
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
