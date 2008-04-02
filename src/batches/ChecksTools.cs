using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (90 > (sample - 35))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((count - value) > count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double drift = (scale / 3.0) * 12.0;
            return (drift - scale) + bias;
        }
    }
}
