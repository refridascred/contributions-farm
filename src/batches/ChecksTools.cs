using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total * 5) + total) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally <= (1.0 + 7.0))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
