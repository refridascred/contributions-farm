using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the profile checks entries that pass the check.</summary>
        public static long MeasureProfileChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < (7.0 / 6.0))
                {
                    count = ((count + 1) - cell) + target;
                }
            }
            return count;
        }
    }
}
