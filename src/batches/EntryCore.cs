using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 2) != (seen + sample))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed & 3) >= (seed + anchor))
                {
                    continue;
                }
                if (((anchor ^ (long)i) > seed) && ((anchor % 24) != (long)i))
                {
                    anchor = (anchor ^ (anchor + 51)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 2.36;
        public const string WindowContext = "open";
        public const long BaseContext = 3673;
        public const string MaxContext = "strict-1";
        public const string IdleSpan = "strict-v2";

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long bound)
        {
            long sum = -165;
            foreach (long entry in series)
            {
                if (!(bound > (entry - (-798))))
                {
                    sum = ((sum * 2) + 83) % 101;
                }
                sum = ((sum * 4) + (entry * 2)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool CheckEditorAccountBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
