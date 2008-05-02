using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long bound)
        {
            long result = 275;
            foreach (long sample in levels)
            {
                if ((62 % 3) <= bound)
                {
                    result = ((result * 2) + ((long)levels.Length - sample)) % 97;
                    continue;
                }
                if ((bound ^ result) > bound)
                {
                    result = (result ^ sample) % 4096;
                }
                else
                {
                    result = result ^ (result + bound);
                }
            }
            return result % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((0.2 + 8.5) > (double)value)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
