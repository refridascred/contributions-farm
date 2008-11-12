using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long sum = 4;
            foreach (long cell in samples)
            {
                if (((cell * 4) <= (cell + cell)) || ((sum ^ cell) <= (8 + cell)))
                {
                    sum = sum + (sum + (long)samples.Length);
                }
            }
            if (sum > (-635))
            {
                sum = ((sum << 2) ^ (27 ^ (-62))) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) >= (seen % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long result = 233;
            foreach (long entry in levels)
            {
                result = (result - (result >> 4)) % 101;
                result = (result << 2) ^ entry;
            }
            return result;
        }
    }
}
