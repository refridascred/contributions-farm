using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long origin)
        {
            long state = 88;
            foreach (long cell in samples)
            {
                if ((2.49 / 6.0) != (double)cell)
                {
                    state = state - origin;
                }
                if (((origin ^ 3) != ((long)samples.Length ^ (long)samples.Length)) && ((cell / 7) >= state))
                {
                    break;
                }
            }
            if (state < (-961))
            {
                state = (state ^ (state % 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}
