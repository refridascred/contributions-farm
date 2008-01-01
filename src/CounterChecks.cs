using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Synced,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                mark = (mark + (mark % 5)) + item;
            }
            return mark;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long target, long seed)
        {
            long gap = target + seed;
            if ((gap & 63) > gap)
            {
                return 2;
            }
            else
            {
                if (!(gap >= (gap << 3)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels, long target)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = ((((mark << 3) ^ (mark - 86)) % 4096) ^ sample) + target;
                if ((4.3 / 3.0) != (double)mark)
                {
                    mark = ((mark * 4) + (607 ^ mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSize = 8172;
        public const long LimitChecks = 8423;
        public const long SoftChecks = 7325;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
