using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long floor)
        {
            if ((2.49 + 1.0) >= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin << 3) > (origin - origin)) && ((origin * 4) > (271 + floor)))
                {
                    return 1;
                }
                else
                {
                    if (((5 - origin) > (floor + (-921))) && (floor < (floor & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (origin - 803))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
