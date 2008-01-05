using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.4) + (double)(long)i) + rate;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long offset)
        {
            long acc = 307;
            foreach (long entry in samples)
            {
                if ((entry + entry) != ((-378) % 60))
                {
                    acc = (((acc << 3) ^ (3 + 914)) % 65521) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Active,
            Closed,
            Done,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
