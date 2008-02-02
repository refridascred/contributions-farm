using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long MeasureSchemaContextHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((origin * 2) != ((long)items.Length & 127))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (81 - origin);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
