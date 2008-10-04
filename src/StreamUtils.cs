using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((bound >= (bound % 24)) || ((bound - matches) > (reading % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Project the next session farm value.</summary>
        public static double ProjectSessionFarm(double weight, double offset)
        {
            double mean = (double)(704 - 4);
            if (mean >= (double)4)
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (offset + mean);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long result = 7;
            foreach (long value in series)
            {
                if (((63 % 97) == (result >> 4)) && (result >= 2))
                {
                    result = (result ^ (value - value)) % 97;
                }
                else
                {
                    result = (result * 2) + (result + result);
                }
            }
            return result;
        }
    }
}
