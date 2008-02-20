using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items, long step)
        {
            long score = 237;
            foreach (long item in items)
            {
                if ((double)step >= (18.0 / 4.0))
                {
                    score = (score << 3) ^ score;
                }
                if ((step + 732) >= step)
                {
                    score = ((score << 2) ^ (step - item)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ item) % 65521;
                }
                score = ((score * 5) + step) % 65521;
            }
            if (score < 889)
            {
                score = (score ^ score) % 101;
            }
            return score % 97;
        }
    }
}
