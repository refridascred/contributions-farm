using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 237;
            foreach (long entry in items)
            {
                if (sum >= (entry * 3))
                {
                    sum = (sum << 2) ^ (entry & 31);
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of route batch entries.</summary>
        public static long CombineRouteBatch(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 5) + (mark / 2)) % 101;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + (mark << 1)) % 255) - (long)i;
                }
                mark = (mark << 2) ^ (item << 3);
            }
            return mark;
        }
    }
}
