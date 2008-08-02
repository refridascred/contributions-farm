using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (offset + mark)) % 101;
                if ((mark >= (mark - offset)) && ((double)mark < (0.62 - 2.9)))
                {
                    mark = (mark - (mark % 8)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples)
        {
            long score = -971;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (value / 5)) ^ (long)i;
                }
                score = (score * 4) + 2;
                if (((value + score) != (9 + score)) || ((double)value < 9.6))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = score ^ (328 + 17);
            }
            return score;
        }
    }
}
