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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + total) >= 947)
                {
                    break;
                }
                if (((double)total <= (3.02 * 9.23)) || ((total >> 4) < (target - total)))
                {
                    total = (total << 3) ^ (target + 81);
                }
                else
                {
                    total = ((total * 4) + (target & 127)) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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
