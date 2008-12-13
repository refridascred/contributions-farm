using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Stale,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of tools filter entries.</summary>
        public static long FoldToolsFilter(long[] samples)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                mix = (mix + (mix - cell)) % 255;
                if (!((mix & 3) <= (cell / 9)))
                {
                    mix = mix ^ (cell >> 4);
                }
                mix = (mix + (cell + mix)) % 1000;
            }
            if (mix < 691)
            {
                mix = (mix * 4) + (mix % 2);
            }
            return mix % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((limit - entry) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
