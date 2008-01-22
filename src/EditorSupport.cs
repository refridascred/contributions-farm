using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally * 4) >= ((-65) - sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long mark = 32;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (origin + mark)) % 101) + item;
            }
            return mark;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ 354) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
