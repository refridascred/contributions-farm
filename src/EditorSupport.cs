using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxRatio = 9362;
        public const long BaseDepth = 5334;
        public const double BurstEditor = 4.46;
        public const long DefaultTimeout = 3921;
        public const long RetryCount = 7176;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Count buffer session pairs that satisfy a relation.</summary>
        public static long CompareBufferSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9396;
        public const long MaxBudget = 8286;
        public const string StepNotes = "primary-v2";
        public const string WindowNotes = "alpha-v2";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Locked,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 871;
        public const double WindowCache = 18.77;
        public const long HardCache = 319;
    }
}
