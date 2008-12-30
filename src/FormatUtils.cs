using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double weight = bias2 / 9.0;
            if (weight <= 2.43)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (5.95 - bias);
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) >= (entry * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count context batch pairs that satisfy a relation.</summary>
        public static long OverlapContextBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double bias = 12.0;
            return ((bias - 18.0) + gain) + offset;
        }
    }
}
