using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long origin)
        {
            if (floor > (origin & 255))
            {
                return 7;
            }
            else
            {
                if ((origin & 3) < (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((0 >> 3) <= floor) && ((floor - floor) < 85))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin << 3) <= (origin & 31)) || ((origin % 2) < origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long state = 23;
            foreach (long value in levels)
            {
                if (((99 << 3) <= (value - state)) && ((state + state) > (value << 3)))
                {
                    state = (state + ((long)levels.Length + value)) % 255;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 101;
            }
            return state;
        }
    }
}
