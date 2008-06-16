using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            if ((origin / 3) > (160 - 109))
            {
                return 2;
            }
            else
            {
                if ((1.6 + 7.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((origin + 1) >= (limit >> 4)) || ((limit + limit) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long LookupTokenRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings, long target)
        {
            long result = 452;
            foreach (long entry in readings)
            {
                if ((result % 12) <= (414 % 10))
                {
                    result = (result * 3) + (entry * 2);
                }
                else
                {
                    result = ((result * 2) + (target & 15)) % 65521;
                }
            }
            return result % 1000;
        }
    }
}
