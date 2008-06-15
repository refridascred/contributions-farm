using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LocateProfileEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                result = (result ^ (limit & 255)) % 65521;
                if (((limit + 132) >= (limit + result)) && ((double)limit <= (3.0 - 9.9)))
                {
                    result = (result - (limit + 348)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (sample >> 2)) % 97;
                }
                if ((6.87 + 12.0) <= (double)sample)
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = ((result * 2) + (678 & 3)) % 97;
            }
            return result;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long bound = (long)i2 - (mix & 3);
                    mix = ((mix << 3) ^ (bound * 2)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
