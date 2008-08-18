using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long origin)
        {
            if ((41 >= (origin + limit)) && ((limit * 3) <= origin))
            {
                return 0;
            }
            else
            {
                if (((origin + limit) >= (origin & 127)) && ((origin ^ limit) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((2.9 / 6.0) <= (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long score = 113;
            foreach (long entry in values)
            {
                score = (((score * 4) + (score + 800)) % 97) - limit;
                score = score ^ entry;
            }
            return score;
        }
    }
}
