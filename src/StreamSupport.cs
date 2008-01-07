using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
