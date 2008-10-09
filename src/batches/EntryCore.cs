using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long offset)
        {
            if (step >= (74 >> 4))
            {
                return 1;
            }
            else
            {
                if ((offset - 8) > 355)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Look up the position of a already format sample.</summary>
        public static long SeekAlreadyFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1772;
        public const long IdleRecord = 83;
        public const long BatchRecord = 9473;
        public const long StepSize = 1156;
        public const long CacheRecord = 8992;

        /// <summary>Roll a format filter counter forward.</summary>
        public static long RollFormatFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
