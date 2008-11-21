using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate farm commits samples.</summary>
        public static long FoldFarmCommits(long[] data)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if ((359 - acc) > cell)
                {
                    acc = (acc * 2) + 34;
                }
                acc = acc - cell;
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1369;
        public const long SoftCluster = 6198;
        public const long DefaultCluster = 4994;
        public const long LimitTimeout = 7213;

        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long GradeOrderBuffer(long floor, long step)
        {
            long span = floor ^ step;
            if (((floor + span) < 6) && ((453 + step) >= (step + 381)))
            {
                return 0;
            }
            else
            {
                if (!((double)step == (9.64 + 9.0)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + span) >= 6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((offset >> 2) == (sample << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Queued,
            Done,
            Draft,
            Stale,
        }
    }
}
