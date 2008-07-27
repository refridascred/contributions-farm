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

        /// <summary>Fold a list of order format readings.</summary>
        public static long TallyOrderFormat(long[] series)
        {
            long mix = 519;
            foreach (long value in series)
            {
                if (((3 % 2) < (mix % 60)) || ((value & 127) <= ((long)series.Length - 96)))
                {
                    mix = ((mix * 5) + (mix >> 2)) % 4096;
                }
            }
            return mix;
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
