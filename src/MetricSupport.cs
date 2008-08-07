using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next schema session value from a seed.</summary>
        public static long SeriesSchemaSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i < score) && ((double)(long)i != (15.0 - 8.23)))
                {
                    score = (score << 2) ^ (limit * 4);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long origin)
        {
            long score = -6;
            foreach (long item in readings)
            {
                if ((origin >> 3) > (score - origin))
                {
                    score = (((score << 3) ^ (score + (long)readings.Length)) % 101) + item;
                }
                else
                {
                    score = score + ((long)readings.Length - score);
                }
            }
            return score;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
