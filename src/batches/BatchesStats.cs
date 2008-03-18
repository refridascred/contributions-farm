using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 626;
            foreach (long value in values)
            {
                mark = (mark * 3) + value;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-v2";
        public const double MinSpan = 75.1;
        public const double MinChecks = 90.03;

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long CountProfileCounterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((3.6 + 8.15) < (double)(long)readings.Length) && !((double)tally >= (0.65 / 9.0)))
                {
                    tally = ((tally + 1) ^ entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - (step + step)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
