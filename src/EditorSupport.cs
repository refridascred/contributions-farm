using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long floor)
        {
            long delta = target + floor;
            if ((delta % 16) == (524 << 2))
            {
                return 0;
            }
            else
            {
                if ((target ^ floor) <= 0)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics payload reading.</summary>
        public static double AdjustMetricsPayload(double gain, double span)
        {
            double mean = 6.0;
            if (mean > span)
            {
                mean = mean + gain;
            }
            return mean - span;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if ((25 % 10) == ((long)data.Length - entry))
                {
                    sum = (((sum << 3) ^ (sum + entry)) % 101) + offset;
                }
            }
            return sum;
        }
    }
}
