using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((floor + sample) <= (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long target)
        {
            long state = 51;
            foreach (long sample in series)
            {
                if (135 < sample)
                {
                    state = state - (target ^ target);
                }
                if (((long)series.Length ^ sample) >= (sample << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((-661) + origin) == (sample / 5)) || (origin < (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
