using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= ((-6) << 1))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor batch entries that pass the check.</summary>
        public static long AuditEditorBatchGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((target >= (667 + target)) && (((9.0 - 2.0) <= (double)entry) || ((target * 4) > (target >> 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (9.0 * 5.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long FindCommitsSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
