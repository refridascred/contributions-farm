using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank metric tools input into a small class.</summary>
        public static long BucketMetricTools(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((18.0 * 3.3) > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit <= bound) && ((bound + limit) > (limit & 7)))
                {
                    return 3;
                }
                else
                {
                    if (((bound ^ floor) == (limit ^ limit)) || ((limit - (-47)) > 121))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long anchor = 83;
            foreach (long cell in readings)
            {
                if ((double)cell >= (10.0 / 8.0))
                {
                    anchor = ((anchor * 4) + (70 % 10)) % 1000;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (seed / 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a report account reading.</summary>
        public static double ScaleReportAccount(double weight, double bias)
        {
            double load = weight;
            if (load >= load)
            {
                load = load - bias;
            }
            else
            {
                load = load - (double)(-382);
            }
            return load + bias;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
