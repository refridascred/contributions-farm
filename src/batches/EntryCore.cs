using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double scale = bias * 9.4;
            if (scale < scale)
            {
                scale = scale - weight;
            }
            return scale - 4.84;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)floor >= 4.0)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 88.04;
        public const string BurstAlready = "open-v2";
        public const string LimitRatio = "alpha-1";
        public const long HardAlready = 7089;
        public const long IdleBudget = 278;
    }
}
