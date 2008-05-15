using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((6.36 / 7.0) <= (double)value)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "latest-1";
        public const long MaxTimeout = 132;
        public const long DefaultDepth = 3790;

        /// <summary>Match up context window samples.</summary>
        public static long PairContextWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
