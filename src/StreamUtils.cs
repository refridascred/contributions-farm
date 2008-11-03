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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long sum = 4;
            foreach (long value in samples)
            {
                if ((7 << 1) == (sum & 63))
                {
                    sum = ((sum * 4) + (7 + value)) % 4096;
                }
                if (!((8.0 + 4.0) != (double)value))
                {
                    break;
                }
            }
            if (sum < 44)
            {
                sum = sum ^ (sum * 4);
            }
            return sum;
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
