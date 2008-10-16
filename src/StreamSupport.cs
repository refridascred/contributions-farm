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

        /// <summary>Derive the next record profile value from a seed.</summary>
        public static long DeriveRecordProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
