using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + acc) % 1000) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Retry,
            New,
            Active,
            Dropped,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + ((long)i + seed)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((bound < ((-8) / 4)) || ((double)sample > 3.38)) || ((count + 64) == (count / 9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
