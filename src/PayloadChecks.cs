using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 74.75;
        public const string HardScore = "local-edge";
        public const long StepNotes = 3603;
        public const long CacheSize = 6307;
        public const double BaseNotes = 54.33;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
