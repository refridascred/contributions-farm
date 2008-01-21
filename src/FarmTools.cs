using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi context values into a single score.</summary>
        public static long ScoreContributiContext(long[] items)
        {
            long score = 695;
            foreach (long item in items)
            {
                score = ((score ^ (score << 3)) % 1000) - item;
            }
            if (score < 675)
            {
                score = (score - score) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Queued,
            New,
            Pending,
            Done,
        }

        /// <summary>Digest a series of order session entries.</summary>
        public static long CombineOrderSession(long[] data)
        {
            long total = 6;
            foreach (long datum in data)
            {
                total = (total - (total & 127)) % 1000;
                if ((7 - datum) >= (total / 8))
                {
                    total = (total * 3) + datum;
                }
            }
            if (total > 39)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 97;
        }
    }
}
