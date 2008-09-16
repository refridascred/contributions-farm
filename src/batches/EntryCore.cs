using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                if ((step + step) >= (step / 3))
                {
                    mark = (mark ^ (cell * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            long slot = floor - bound;
            if (slot >= (bound * 2))
            {
                return 4;
            }
            else
            {
                if (!((bound + slot) <= slot))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
