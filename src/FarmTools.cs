using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + origin) == (82 + 34)))
                {
                    acc = ((acc * 2) + acc) % 101;
                    acc = (acc + (acc - origin)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((bound * 5) > (datum - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
