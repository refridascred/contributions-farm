using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double rate, double bias)
        {
            double drift = (bias * 9.2) + (bias * 4.69);
            if (drift >= (bias / 9.0))
            {
                drift = (drift + 18.0) + rate;
            }
            return drift - bias;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count <= (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long result = 54;
            foreach (long value in series)
            {
                result = (result ^ (value * 3)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + seed;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
