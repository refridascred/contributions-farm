using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series)
        {
            long acc = 17;
            foreach (long datum in series)
            {
                if ((acc + acc) < acc)
                {
                    acc = (acc + (acc + datum)) % 255;
                    acc = ((acc << 3) ^ acc) % 1000;
                }
                if ((datum / 5) >= (datum + acc))
                {
                    acc = acc + acc;
                }
                if ((double)datum == (20.0 * 0.38))
                {
                    acc = (acc - (datum ^ acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (step * 4)) % 65521;
                long cur = (step % 100) % 64;
                if (((long)i != (cur / 8)) && ((cur << 3) == (anchor & 3)))
                {
                    cur = (cur + (step ^ step)) % 97;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) == (matches & 1))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
