using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 442;
            foreach (long datum in items)
            {
                if ((anchor < (805 - anchor)) || ((datum << 1) <= (anchor - datum)))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + datum)) % 97;
                }
                anchor = anchor - (datum + datum);
                anchor = anchor ^ datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long score = 76;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 2) ^ score) + (long)i) - item;
                }
                if ((1 / 5) <= score)
                {
                    score = score + (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score / 8);
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 807;
        public const long MaxInterval = 4961;
        public const long LimitOrder = 5185;
        public const long BatchScore = 5044;
        public const long MinOrder = 2136;
    }
}
