using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + ((-31) * 2)) % 4096) ^ sample;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (anchor + entry)) || ((step + anchor) != (step << 2)))
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 9219;
        public const long StepFactor = 23;
        public const double StepWindow = 44.63;
        public const string MinCount = "standard-v2";
        public const string RetryCount = "fallback";

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheInterval = 5131;
        public const long WindowBatch = 9270;
        public const long SoftBatch = 8890;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
