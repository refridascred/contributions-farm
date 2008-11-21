using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a schema command counter forward.</summary>
        public static long DeriveSchemaCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin <= (long)i)
                {
                    result = (result << 3) ^ origin;
                }
                result = result + (origin - origin);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)seed > 14.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
