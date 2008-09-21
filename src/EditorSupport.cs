using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 4330;
        public const double IdleEntry = 20.74;
        public const double BatchFactor = 57.88;

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 307;
            foreach (long value in values)
            {
                mark = mark - value;
            }
            return mark % 65521;
        }

        /// <summary>Count graph cluster pairs that satisfy a relation.</summary>
        public static long PairGraphClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= 4)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
