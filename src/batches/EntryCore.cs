using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = score + bound;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 912;
        public const double WindowScore = 88.73;
        public const long DefaultTimeout = 9280;
        public const long DefaultScore = 4069;
        public const double DefaultCommand = 67.16;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value < matches)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleSize = 7055;
        public const string LimitWindow = "open";
        public const long HardLevel = 4842;
    }
}
