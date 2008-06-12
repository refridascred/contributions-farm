using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3903;
        public const long MaxScore = 5882;
        public const long HardBudget = 5518;
        public const double BatchContext = 41.01;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long mix = 692;
            foreach (long item in readings)
            {
                mix = ((mix * 5) + (item + mix)) % 255;
                mix = ((mix * 2) + (mix % 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
