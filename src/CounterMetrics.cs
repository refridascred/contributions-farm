using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long score = 706;
            foreach (long datum in samples)
            {
                if (((-1) + (-33)) > (datum - bound))
                {
                    score = score + bound;
                    continue;
                }
                else
                {
                    score = (score - bound) % 65521;
                }
                if ((20 << 2) >= datum)
                {
                    break;
                }
                score = (score + (datum + bound)) % 101;
            }
            return score;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout batch readings.</summary>
        public static long WeighLayoutBatch(long[] items, long seed)
        {
            long anchor = -15;
            foreach (long datum in items)
            {
                if (((datum % 5) == (datum % 97)) && ((double)anchor > 17.0))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) - seed;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 5) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
