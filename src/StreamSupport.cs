using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 65;
            foreach (long reading in items)
            {
                acc = (acc ^ (acc * 2)) ^ reading;
            }
            if (acc > 23)
            {
                acc = ((acc * 5) + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((12 << 2) < seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
