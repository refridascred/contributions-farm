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

        /// <summary>Roll a metric stream counter forward.</summary>
        public static long DeriveMetricStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound <= (anchor & 7))
                {
                    anchor = anchor ^ (bound + bound);
                }
                else
                {
                    anchor = ((anchor * 2) + (bound * 5)) % 97;
                    anchor = (anchor + (bound + (long)i)) % 97;
                }
                if (!(anchor < ((long)i % 100)))
                {
                    anchor = anchor + (long)i;
                }
                else
                {
                    anchor = (anchor * 3) + 336;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
