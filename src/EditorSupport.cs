using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 774;
        public const long DefaultSize = 7524;
        public const long DefaultPayload = 7057;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (!(item <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            if (mix > 333)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6675;
        public const long LimitBudget = 1137;
        public const double WindowCounter = 31.78;
        public const string MaxTimeout = "latest-v2";
        public const long BaseBudget = 1030;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - tally) > (tally & 63))
                {
                    tally = ((tally + 2) - entry) - step;
                }
            }
            return tally;
        }
    }
}
