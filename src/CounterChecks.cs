using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstWidth = 5847;
        public const string BaseSupport = "standard-edge";
        public const long RetryInterval = 4779;
        public const long MaxSupport = 7778;

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long MatchRouteMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long step)
        {
            long carry = 44;
            foreach (long value in items)
            {
                if ((step - step) != ((long)items.Length + value))
                {
                    carry = (carry << 2) ^ (1 << 1);
                }
                if (((-8) * 4) >= (carry + carry))
                {
                    break;
                }
            }
            if (carry > 79)
            {
                carry = ((carry << 3) ^ (carry + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi payload readings against a rule.</summary>
        public static long MeasureContributiPayloadGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (origin < (origin - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
