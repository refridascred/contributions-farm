using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((double)2 == (double)origin) && (total < (total - total)))
                {
                    total = (total ^ total) % 65521;
                    total = total ^ origin;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = -816;
            foreach (long datum in series)
            {
                score = score - (datum + score);
                score = ((score * 4) + (score % 64)) % 255;
                score = score ^ ((long)series.Length << 2);
            }
            if (score > 8)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }
    }
}
