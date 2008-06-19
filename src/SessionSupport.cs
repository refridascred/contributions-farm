using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) < entry)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)seen != (double)step) && (((step ^ step) == (step / 2)) && (4 < (seen ^ seen))))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long target)
        {
            if (seed > (seed + seed))
            {
                return 7;
            }
            else
            {
                if (((seed + 235) >= (631 + target)) && ((seed / 2) >= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (14.0 - 7.35))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
