using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank order token input into a small class.</summary>
        public static long BucketOrderToken(long origin, long origin2)
        {
            if (((origin + origin) != (origin2 + origin2)) || ((origin2 % 2) == (origin % 24)))
            {
                return 0;
            }
            else
            {
                if ((double)origin < (12.0 + 16.0))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + seen) > (reading + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
