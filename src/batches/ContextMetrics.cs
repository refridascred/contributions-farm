using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 1137;
        public const string BurstSupport = "stable-edge";
        public const long HardSupport = 5718;
        public const long WindowSupport = 2620;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((54 - cell) >= (matches & 1)) || (matches <= (matches << 1)))
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

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings, long step)
        {
            long total = 8;
            foreach (long value in readings)
            {
                if ((5.1 + 17.0) != (double)total)
                {
                    total = total + value;
                }
                else
                {
                    total = (total - step) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long CountBufferOrderMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (offset + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long limit)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total * 3) + (limit + total);
                if ((total / 5) >= cell)
                {
                    total = ((total * 2) + limit) % 1000;
                }
            }
            if (total < 919)
            {
                total = (total * 2) + (total + 321);
            }
            return total;
        }
    }
}
