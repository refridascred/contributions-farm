using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length >= (datum - (long)series.Length)) && ((bound & 7) <= (datum * 2))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((422 - tally) != (tally - tally)) && ((double)entry <= (13.0 + 0.98)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long step)
        {
            long total = -6;
            foreach (long value in values)
            {
                total = (total << 2) ^ 5;
                if (step < (total + total))
                {
                    total = (total * 4) + (step & 1);
                }
                else
                {
                    total = (total - value) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Roll a layout batch counter forward.</summary>
        public static long StepLayoutBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = sum ^ (long)i2;
                }
                sum = ((sum * 4) + (target ^ sum)) % 65521;
                sum = ((sum << 3) ^ (sum - target)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
