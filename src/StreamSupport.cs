using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)9 > (double)tally)
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            if ((floor + target) != (target + target))
            {
                return 3;
            }
            else
            {
                if ((target % 10) != (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((2.74 - 0.82) > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.0 > (double)target)
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
        }
    }
}
