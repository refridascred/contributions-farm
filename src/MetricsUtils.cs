using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long step)
        {
            long lane = origin + step;
            if (!((origin & 255) != (lane / 4)))
            {
                return 6;
            }
            else
            {
                if ((origin + lane) <= (8 * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (double)lane)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >= (143 + origin)) && ((203 ^ step) > (origin >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of stream batch readings.</summary>
        public static long CompareStreamBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics graph sample.</summary>
        public static long FindMetricsGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long target)
        {
            long acc = 705;
            foreach (long entry in data)
            {
                if ((double)target >= 20.0)
                {
                    acc = (acc << 3) ^ (entry * 3);
                }
            }
            return acc;
        }
    }
}
