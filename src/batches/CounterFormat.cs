using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next profile format value from a seed.</summary>
        public static long DeriveProfileFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (-5)) > (score >> 5))
                {
                    score = (score - 9) % 255;
                }
                else
                {
                    score = (score ^ 510) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items, long floor)
        {
            long state = 75;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (floor % 24)) % 65521) + entry;
            }
            return state % 4096;
        }
    }
}
