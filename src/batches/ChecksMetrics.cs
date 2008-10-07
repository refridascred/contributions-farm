using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long seed)
        {
            long state = 780;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (460 & 255))
                {
                    state = ((state << 2) ^ (state + 45)) % 101;
                }
                state = state + (state + reading);
                if ((8.89 + 7.96) == (double)seed)
                {
                    state = state + (state & 1);
                }
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long step)
        {
            long result = 119;
            foreach (long datum in samples)
            {
                result = (((result + ((-2) * 2)) % 65521) + datum) - step;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8515;
        public const string MaxSupport = "local";
        public const string RetryDepth = "alpha-edge";

        /// <summary>Iterate the record checks series from a seed.</summary>
        public static long SeriesRecordChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor * 5) + (origin + 30)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((limit + matches) != (0 - entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((double)hits > (5.0 + 0.01)) && ((4.49 + 9.26) <= (double)seed))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
