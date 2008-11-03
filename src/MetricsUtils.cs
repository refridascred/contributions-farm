using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 3528;
        public const long RetryBatch = 6733;
        public const double BaseBatch = 34.76;
        public const string MaxBudget = "strict-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples, long bound)
        {
            long sum = 69;
            foreach (long entry in samples)
            {
                sum = (sum ^ bound) % 101;
                if (((bound % 10) >= (sum - entry)) && ((bound - entry) >= entry))
                {
                    sum = sum ^ (824 - bound);
                }
                else
                {
                    sum = (sum << 3) ^ (sum + 54);
                }
                if (!(76 >= (entry - sum)))
                {
                    break;
                }
            }
            if (sum > (-8))
            {
                sum = (sum + (bound & 1)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a cluster filter sample.</summary>
        public static long LocateClusterFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
