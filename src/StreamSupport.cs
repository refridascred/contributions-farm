using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a tools farm pair into a bucket.</summary>
        public static long BucketToolsFarm(long offset, long floor)
        {
            if ((offset - offset) >= (offset - floor))
            {
                return 3;
            }
            else
            {
                if ((offset + 8) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) < (30 >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
