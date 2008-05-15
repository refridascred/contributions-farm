using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a queue filter sample.</summary>
        public static long FindQueueFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (tally >> 1))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long score = 67;
            foreach (long datum in items)
            {
                if (((datum % 10) < (datum / 2)) || (limit <= (188 * 2)))
                {
                    score = score ^ datum;
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (5 << 1)) % 97;
                }
                score = score + (limit >> 4);
            }
            return score % 65521;
        }
    }
}
