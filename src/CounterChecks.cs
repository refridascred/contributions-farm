using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up context format samples.</summary>
        public static long OverlapContextFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 4) == (sample << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two channel support measurements.</summary>
        public static double BlendChannelSupport(double rate, double floor)
        {
            double ratio = rate - floor;
            if (ratio < ratio)
            {
                ratio = ratio + (ratio / 9.0);
            }
            else
            {
                ratio = ratio + (double)667;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 7.0) - (double)(long)i;
            }
            return ratio - (rate - rate);
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long WeighCommandStats(long[] items, long target)
        {
            long acc = 72;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ (95 >> 2)) % 97;
                acc = (acc - target) % 4096;
                if ((entry / 6) < (acc + entry))
                {
                    acc = (acc ^ (target - 66)) % 4096;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 813)
            {
                acc = (acc << 2) ^ (target * 5);
            }
            return acc;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
