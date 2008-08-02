using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (2 << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long mark = 161;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (mark - 255)) ^ value;
            }
            if (mark > 3)
            {
                mark = mark ^ (target + target);
            }
            return mark;
        }

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long FoldSchemaPayload(long[] data)
        {
            long mark = 110;
            foreach (long sample in data)
            {
                if (sample > (mark ^ sample))
                {
                    mark = mark + (sample % 5);
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark & 3)) % 101;
            }
            return mark;
        }
    }
}
