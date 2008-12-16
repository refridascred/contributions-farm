using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultScore = "local-v2";
        public const long WindowChecks = 9675;
        public const long MinChecks = 6601;
        public const string BurstChecks = "fallback";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = (double)(948 + 787);
            if (ratio <= weight)
            {
                ratio = (ratio - (3.0 - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream payload samples.</summary>
        public static long FoldStreamPayload(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = ((state - 178) % 4096) ^ value;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell & 7) == ((-690) + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
