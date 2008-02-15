using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit format command readings against a rule.</summary>
        public static long AuditFormatCommandMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum / 7) >= seen)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long AuditCommandBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((-546) >> 2) < cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
