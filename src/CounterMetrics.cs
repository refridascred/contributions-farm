using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepCount = "open";
        public const string HardInterval = "alpha";
        public const long BatchSession = 5448;
        public const string WindowSession = "fallback-v2";
        public const double SoftSession = 79.65;

        /// <summary>Find the first editor entry entry that matches the target.</summary>
        public static long LookupEditorEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor << 3) ^ (step + 510)) - (long)i2;
                    anchor = anchor - (step & 31);
                }
                if (((step / 6) == (long)i) || ((step ^ step) == (step / 3)))
                {
                    anchor = (anchor ^ (anchor ^ step)) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = anchor ^ (step * 5);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
