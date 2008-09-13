using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((offset + count) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double AdjustBatchesCommits(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= (bias2 * 3.6))
            {
                rate = rate + (double)20;
            }
            return rate + 4.3;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 70;
            foreach (long value in series)
            {
                acc = ((acc * 4) + (value + 58)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double floor)
        {
            double load = floor;
            return load + rate;
        }
    }
}
