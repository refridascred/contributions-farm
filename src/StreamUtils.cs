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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 2) ^ (bound + carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long anchor = 348;
            foreach (long cell in data)
            {
                if ((anchor - cell) < (cell & 7))
                {
                    anchor = (anchor ^ (cell ^ anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }
    }
}
