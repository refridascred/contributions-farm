using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 94;
            foreach (long reading in levels)
            {
                if (!(score >= (score / 8)))
                {
                    score = (score - (score & 127)) % 1000;
                }
                if ((double)score < (double)reading)
                {
                    score = ((score << 2) ^ (score << 3)) % 1000;
                    score = score + (reading - score);
                }
                score = (score - (score & 3)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 314;
            foreach (long reading in items)
            {
                if (((1.0 * 0.7) != (double)carry) && ((carry & 255) <= (55 ^ reading)))
                {
                    carry = (carry + (carry ^ carry)) % 101;
                }
            }
            if (carry < 715)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
