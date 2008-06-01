using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a buffer layout pair into a bucket.</summary>
        public static long GradeBufferLayout(long bound, long origin)
        {
            if ((bound - origin) < (origin % 64))
            {
                return 4;
            }
            else
            {
                if (((origin & 7) <= bound) || ((origin * 5) >= (origin - 170)))
                {
                    return 0;
                }
                else
                {
                    if ((double)18 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 4.0) == (double)seen)
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
    }
}
