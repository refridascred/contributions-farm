using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((126 + reading) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long anchor = 957;
            foreach (long cell in samples)
            {
                anchor = anchor + (offset + cell);
                if ((double)anchor >= 4.9)
                {
                    anchor = anchor ^ anchor;
                    anchor = (anchor * 3) + cell;
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                    anchor = anchor + (anchor + anchor);
                }
                if (offset < (77 * 2))
                {
                    anchor = (anchor + (0 / 4)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) != ((long)values.Length >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 2494;
        public const double DefaultSpan = 14.38;
        public const long SoftLevel = 1148;
        public const double BaseBudget = 36.1;
        public const long RetryWindow = 2221;
    }
}
