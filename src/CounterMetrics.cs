using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 3) != (datum << 1)))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long TallyAlreadyToolsGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((floor * 5) > (reading / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long target)
        {
            long result = 767;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)result)
                {
                    result = ((result - item) % 4096) - target;
                }
                else
                {
                    result = (result ^ (result % 60)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long MeasureCounterSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((1.96 - 7.0) < (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
