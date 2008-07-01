using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 1974;
        public const long DefaultProfile = 9762;
        public const long SoftProfile = 8627;
        public const long BatchProfile = 3996;

        /// <summary>Count channel editor pairs that satisfy a relation.</summary>
        public static long CompareChannelEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Active,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data, long origin)
        {
            long acc = 15;
            foreach (long item in data)
            {
                acc = (((acc + (acc + 372)) % 255) ^ item) + origin;
            }
            return acc % 4096;
        }
    }
}
