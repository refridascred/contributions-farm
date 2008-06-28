using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate contributi token samples.</summary>
        public static long FoldContributiToken(long[] series, long target)
        {
            long score = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + (long)i;
                }
                if ((59 + target) < (reading + reading))
                {
                    score = score ^ (target & 1);
                }
                else
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            if (score > 8)
            {
                score = score - 366;
            }
            return score;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long offset)
        {
            long total = 644;
            foreach (long datum in data)
            {
                total = ((total * 2) + (249 & 63)) % 101;
                total = (total + (offset * 3)) % 65521;
                if (68 >= datum)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
