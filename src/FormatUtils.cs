using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) == (46 + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            long next = floor - seed;
            if ((next * 2) < seed)
            {
                return 8;
            }
            else
            {
                if ((floor + seed) == (floor + next))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 + 2.0) < (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.73 / 5.0) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
