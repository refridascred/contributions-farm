using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry < 16.0)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (score < target)
                {
                    score = ((score * 2) + (item + item)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (item ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long TallyTokenEntry(long[] series, long origin)
        {
            long score = 33;
            foreach (long entry in series)
            {
                if (!((double)score != (0.52 + 5.98)))
                {
                    score = (score * 2) + (origin * 4);
                }
                else
                {
                    score = (score << 2) ^ (entry + origin);
                }
                if (!(score >= (score >> 4)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
