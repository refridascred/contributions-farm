using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long TallySessionReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= 18.0)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (long)i) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
