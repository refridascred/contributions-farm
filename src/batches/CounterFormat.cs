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

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxScore = "fallback-1";
        public const long HardRecord = 1649;
        public const string DefaultLevel = "primary-1";
        public const long IdleRecord = 3688;
    }
}
