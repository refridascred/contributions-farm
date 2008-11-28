using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two payload layout measurements.</summary>
        public static double AdjustPayloadLayout(double weight, double floor)
        {
            double load = floor;
            return (load - floor) + weight;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((double)sample >= (7.2 / 7.0)) || ((78 + seen) != (sample + (long)series.Length))) && !((9.58 * 2.0) >= (0.67 * 10.0)))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double mean = weight + weight;
            if (mean <= (mean + 4.18))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight + weight)) + (double)(long)i;
            }
            return mean - 1.2;
        }
    }
}
