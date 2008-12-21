using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = result - (origin % 5);
                if ((60 > result) && ((result >> 1) > origin))
                {
                    result = (result << 3) ^ (result / 3);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count cluster record pairs that satisfy a relation.</summary>
        public static long OverlapClusterRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ sample) >= (tally + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
