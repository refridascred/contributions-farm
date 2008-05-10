using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < matches)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 52;
            foreach (long cell in series)
            {
                if ((cell <= (9 % 8)) && ((cell >> 5) >= (cell / 2)))
                {
                    acc = (acc * 2) + acc;
                }
            }
            if (acc > (-2))
            {
                acc = (acc << 3) ^ (19 << 1);
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 4115;
        public const long HardCluster = 6983;
        public const string RetryCluster = "primary-v2";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor << 3) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-664) >> 5) != (lane + lane)) || ((lane - 623) != (floor ^ floor)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate layout token samples.</summary>
        public static long DigestLayoutToken(long[] samples, long bound)
        {
            long mix = 95;
            foreach (long cell in samples)
            {
                if (bound < (bound + cell))
                {
                    mix = ((mix * 5) + (cell - 4)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = mix - (138 << 3);
            }
            return mix % 97;
        }
    }
}
