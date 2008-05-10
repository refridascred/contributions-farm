using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items, long target)
        {
            long result = 4;
            foreach (long entry in items)
            {
                result = result - (entry + target);
                if (result <= 93)
                {
                    result = ((result * 5) + target) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (6 + 30)) % 1000;
                }
            }
            if (result < 545)
            {
                result = (result ^ 0) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + (bound % 24)) % 97;
                anchor = (anchor - anchor) % 255;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((sample + sample) < (seen & 31)) || ((372 - sample) < (seen % 5))) || (seen <= (sample ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (28 - 857))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
