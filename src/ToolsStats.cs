using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mix = 482;
            foreach (long entry in data)
            {
                if (9 >= (mix ^ entry))
                {
                    mix = mix + (entry / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (total + 29)) % 97;
                total = (total + (origin >> 3)) % 4096;
                total = total ^ origin;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double load = (ratio * 1.7) / 9.0;
            if (load < floor)
            {
                load = load - (double)(-83);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)31;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
