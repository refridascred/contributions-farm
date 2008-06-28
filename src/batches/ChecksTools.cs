using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the schema cache entries that pass the check.</summary>
        public static long AuditSchemaCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ (result / 3)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
