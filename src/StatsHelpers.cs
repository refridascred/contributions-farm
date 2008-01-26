using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (24 ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)value < (double)floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up schema tools samples.</summary>
        public static long PairSchemaToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset >> 4) <= (65 - anchor)) || (offset <= (4 - offset)))
                {
                    anchor = ((anchor * 5) + ((long)i & 15)) % 97;
                }
                anchor = ((anchor << 2) ^ (offset * 4)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 5994;
        public const double MinScore = 98.74;
        public const string LimitMetrics = "open";
    }
}
