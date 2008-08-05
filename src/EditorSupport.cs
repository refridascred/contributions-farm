using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally / 9) >= (offset - offset))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length & 7) > (85 + matches)) || ((double)reading != (double)98)) && (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)577 <= (double)seed)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "cached-1";
        public const long HardSize = 984;
        public const long RetrySpan = 3097;
        public const long MinFilter = 488;
        public const string IdleFilter = "staging";

        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long DeriveBatchesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)sum > (0.5 + 2.1))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
