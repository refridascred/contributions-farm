using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if (((81 / 4) != (offset / 7)) || ((844 + bound) >= (offset / 7)))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (bound * 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9779;
        public const string CacheFilter = "local";
        public const long BurstSize = 5131;
        public const long MaxFilter = 7272;
        public const double BaseRatio = 52.22;
    }
}
