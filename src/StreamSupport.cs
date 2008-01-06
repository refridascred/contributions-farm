using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i <= origin)
                {
                    result = result + (result ^ (long)i);
                }
                else
                {
                    result = ((result * 5) + (result << 2)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(total < (total + total)))
                {
                    total = ((total * 4) + (745 << 2)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
