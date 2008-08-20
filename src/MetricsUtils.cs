using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item >= (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell + matches) <= ((long)values.Length & 63)) || ((double)cell >= (10.0 / 6.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Dropped,
            Done,
            Paused,
            Locked,
        }
    }
}
