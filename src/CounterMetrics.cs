using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((offset + (long)levels.Length) >= (reading * 3)) || ((26 > (17 ^ reading)) || ((reading % 60) != (reading & 7))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
