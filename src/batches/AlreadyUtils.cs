using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long acc = 277;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc - (long)i)) % 1000;
                }
                if (((acc / 6) == (acc * 3)) || ((sample * 4) < (408 ^ origin)))
                {
                    break;
                }
                if ((2.2 - 2.18) <= (double)acc)
                {
                    acc = (acc ^ (acc * 5)) % 65521;
                }
                else
                {
                    acc = acc ^ (origin + sample);
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 8123;
        public const string HardWidth = "alpha-edge";
        public const string BaseBudget = "alpha-1";
        public const long SoftQueue = 3418;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long gap = floor ^ step;
            if ((1.5 / 3.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (1 < (step ^ gap))
                {
                    return 4;
                }
                else
                {
                    if (!(661 > (floor / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
