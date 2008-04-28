using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long step)
        {
            if (step > (5 + (-46)))
            {
                return 1;
            }
            else
            {
                if ((floor ^ floor) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) > (73 / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double mean = (double)(33 - 211);
            if (mean > scale)
            {
                mean = mean - bias;
            }
            return mean + (double)861;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
