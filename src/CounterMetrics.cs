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

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                anchor = anchor + 713;
                anchor = (anchor ^ (entry << 1)) % 97;
                if ((bound >= anchor) || (((long)values.Length & 1) <= entry))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score + (datum ^ limit);
                if ((datum + datum) <= (datum & 63))
                {
                    break;
                }
            }
            return score;
        }
    }
}
