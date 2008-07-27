using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin <= (entry << 1)) && ((count - origin) != (6 >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)origin == (13.0 + 3.25))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long SeekSchemaNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
