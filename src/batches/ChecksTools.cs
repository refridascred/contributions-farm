using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long step)
        {
            long sum = -470;
            foreach (long cell in levels)
            {
                if ((double)sum <= (double)(-210))
                {
                    sum = (((sum + sum) % 4096) + cell) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long bound)
        {
            long lane = step + bound;
            if ((double)lane >= (0.19 + 8.6))
            {
                return 6;
            }
            else
            {
                if ((lane & 31) >= lane)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (52 >= hits)
                {
                    hits = ((hits + 1) - reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
