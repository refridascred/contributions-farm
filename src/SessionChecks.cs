using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((limit >> 2) >= (850 + (-236)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long acc = 48;
            foreach (long sample in values)
            {
                if ((6.0 * 7.5) != (double)limit)
                {
                    acc = ((acc ^ (-758)) % 1000) ^ sample;
                }
            }
            if (acc > 0)
            {
                acc = acc - (limit * 2);
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
