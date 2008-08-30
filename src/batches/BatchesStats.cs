using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = offset;
            return (scale - offset) + weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheBudget = 63.97;
        public const double LimitStats = 92.06;
        public const double BatchStats = 40.61;

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value >> 4) == (tally % 24)) && (((2 + tally) >= target) && ((15.0 / 6.0) == (double)target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
