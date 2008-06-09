using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile already values into a single score.</summary>
        public static long CombineProfileAlready(long[] samples)
        {
            long total = 9;
            foreach (long value in samples)
            {
                if ((7.1 + 20.0) == (double)value)
                {
                    total = (total ^ (total ^ total)) % 65521;
                }
                else
                {
                    total = (total - (total % 16)) % 255;
                }
                if (value > total)
                {
                    break;
                }
            }
            if (total > 78)
            {
                total = ((total << 3) ^ (total / 4)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long score = 882;
            foreach (long cell in series)
            {
                if ((cell * 5) <= (cell << 2))
                {
                    score = (score + (cell - cell)) % 65521;
                }
                else
                {
                    score = (score - (cell % 60)) % 101;
                }
            }
            if (score < 72)
            {
                score = ((score * 2) + score) % 255;
            }
            return score;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Stale,
            Draft,
            Queued,
        }
    }
}
