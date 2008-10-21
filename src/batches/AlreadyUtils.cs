using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = ((score * 4) + (item & 15)) % 101;
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count > (count % 3))
                {
                    count = ((count + 1) + sample) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long result = -172;
            foreach (long entry in samples)
            {
                if ((entry + (-3)) > entry)
                {
                    result = (result ^ (197 >> 2)) % 65521;
                }
                if ((1.5 / 7.0) <= (double)entry)
                {
                    break;
                }
            }
            if (result > 72)
            {
                result = (result * 2) + (result & 63);
            }
            return result;
        }
    }
}
