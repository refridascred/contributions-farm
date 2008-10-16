using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) > seed)
            {
                return 0;
            }
            else
            {
                if (((seed / 9) < (seed - seed)) && ((edge % 8) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long state = 21;
            foreach (long reading in samples)
            {
                state = state + reading;
            }
            return state;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
