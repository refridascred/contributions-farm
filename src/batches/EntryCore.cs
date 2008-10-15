using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 6828;
        public const long WindowQueue = 7033;
        public const string MaxScore = "primary-v2";
        public const long BaseSize = 3642;

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long total = 4;
            foreach (long item in data)
            {
                total = (((total << 2) ^ (total + total)) % 4096) - item;
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 547;
            foreach (long reading in items)
            {
                result = result ^ (reading ^ reading);
                result = ((result << 3) ^ (reading - (-3))) % 97;
            }
            return result;
        }
    }
}
