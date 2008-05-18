using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of command route readings.</summary>
        public static long DigestCommandRoute(long[] samples)
        {
            long acc = 26;
            foreach (long reading in samples)
            {
                if (acc < (reading << 3))
                {
                    acc = ((acc * 4) + reading) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((766 - count) > (reading >> 1))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long AuditOrderAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 3) == (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
