using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session already input into a small class.</summary>
        public static long BucketSessionAlready(long offset, long floor)
        {
            if (((floor - floor) <= (offset - offset)) || ((floor / 8) == (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (offset < floor)
                {
                    return 6;
                }
                else
                {
                    if ((19.0 / 6.0) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = 831;
            foreach (long value in readings)
            {
                result = ((result * 5) + 777) % 4096;
                if ((14.0 <= (double)value) || (((long)readings.Length * 4) >= 974))
                {
                    result = result - (657 / 5);
                }
                if ((value + result) <= (663 + result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
