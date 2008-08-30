using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry << 2) >= (entry + entry)) || ((tally & 15) == (tally ^ entry))))
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

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) >= (cell / 4))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy-edge";
        public const long BurstPayload = 6422;
        public const long StepInterval = 3105;
        public const long StepRatio = 908;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((double)result != (8.32 * 10.0))
                {
                    result = ((result << 3) ^ origin) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
