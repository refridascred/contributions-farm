using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of metrics commits readings.</summary>
        public static long MatchMetricsCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 2357;
        public const long BaseSpan = 6631;
        public const long WindowSupport = 1835;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((value ^ value) >= value) || ((value / 5) > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long DigestEditorCommand(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                if (((-169) ^ score) == (score + score))
                {
                    score = (score ^ sample) % 97;
                }
                else
                {
                    score = (score ^ sample) % 65521;
                }
                if (!(score > (score + 550)))
                {
                    break;
                }
            }
            if (score > 68)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value < (2.95 * 8.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
