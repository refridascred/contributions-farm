using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] samples, long target)
        {
            long total = 3;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (-14)) % 4096;
                if ((3.2 * 6.6) > (double)target)
                {
                    total = total + value;
                }
                else
                {
                    total = ((total * 3) + (total << 2)) % 255;
                }
            }
            if (total < 17)
            {
                total = total ^ (total + target);
            }
            return total % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (floor - scale) / 4.0;
            if (ratio > ratio)
            {
                ratio = ratio + (4.0 * 10.0);
            }
            else
            {
                ratio = ratio + (ratio + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (scale + ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long LocateAlreadyCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
