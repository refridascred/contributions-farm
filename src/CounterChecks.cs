using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a metrics filter pair into a bucket.</summary>
        public static long SortMetricsFilter(long floor, long seed)
        {
            if (((-319) / 2) <= (floor + seed))
            {
                return 6;
            }
            else
            {
                if (((floor % 3) == (floor ^ floor)) && ((double)seed > (6.9 + 9.8)))
                {
                    return 1;
                }
                else
                {
                    if ((968 > (floor % 16)) && (((-3) ^ seed) != (floor % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) > (floor + 29))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 2) == (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + (bias * 5.4);
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ (acc * 5);
                acc = (acc ^ bound) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
