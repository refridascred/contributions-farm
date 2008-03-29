using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)603 != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples, long step)
        {
            long acc = -597;
            foreach (long reading in samples)
            {
                if (((long)samples.Length << 2) <= reading)
                {
                    acc = ((acc * 3) + reading) % 1000;
                }
            }
            if (acc > 342)
            {
                acc = acc - (step ^ acc);
            }
            return acc;
        }
    }
}
