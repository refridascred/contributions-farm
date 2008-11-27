using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                long lane = total - total;
                total = (total + ((long)i + lane)) % 65521;
                total = (total - (total / 9)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series)
        {
            long mark = 461;
            foreach (long value in series)
            {
                if ((23 / 5) > (value / 8))
                {
                    mark = (mark * 4) + (value - mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((offset % 3) >= (offset / 8)) || (offset > entry)) && ((offset * 5) == (179 / 9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
