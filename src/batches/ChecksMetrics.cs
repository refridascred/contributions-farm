using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((double)(long)i <= 0.2) || ((sum + sum) <= 45))
                {
                    long lane = origin;
                    sum = (sum - (sum - lane)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultWidth = 63.48;
        public const long RetryDepth = 9584;
        public const double DefaultFactor = 56.35;
        public const string BurstSize = "staging";
        public const long DefaultCommand = 5561;

        /// <summary>Count context notes pairs that satisfy a relation.</summary>
        public static long PairContextNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((2.5 - 4.2) > (double)seed)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long FindContextSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
