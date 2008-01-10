using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double rate, double span)
        {
            double mean = span + span;
            if (mean >= 5.22)
            {
                mean = (mean - (mean + span)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)24) + (double)(long)i;
            }
            return mean + 9.8;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
