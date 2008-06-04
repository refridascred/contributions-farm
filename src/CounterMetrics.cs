using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next order graph value.</summary>
        public static double SmoothOrderGraph(double bias, double offset)
        {
            double bias2 = (offset * 5.1) - (offset / 4.0);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + 10.0) - (double)(long)i) - bias;
            }
            return bias2 + (double)(-56);
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long TallyBatchesReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading ^ matches) >= reading) && ((matches + 2) == (reading + reading))) || ((17.0 + 3.3) > (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long bound)
        {
            if ((19.0 - 5.0) != (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (4.8 * 2.9))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
