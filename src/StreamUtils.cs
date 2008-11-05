using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9864;
        public const double WindowBuffer = 89.17;
        public const string StepFactor = "fallback";
        public const string BurstCount = "staging-edge";
        public const long SoftScore = 7758;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double weight = gain;
            if (weight <= (gain / 3.0))
            {
                weight = (weight - gain) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (gain + gain)) - (double)(long)i;
            }
            return weight - (double)443;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
