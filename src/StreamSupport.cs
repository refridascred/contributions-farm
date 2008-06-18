using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (seen & 255)) || (((seen * 2) == (reading - reading)) || (reading > (seen & 7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark - ((long)i2 - (long)i)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Locked,
            Done,
            New,
            Retry,
        }
    }
}
