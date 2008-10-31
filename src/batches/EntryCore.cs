using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item + 48))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 189;
            foreach (long reading in readings)
            {
                mix = (mix - (reading + reading)) % 4096;
                if ((9 > (reading + 63)) || ((double)mix >= (double)reading))
                {
                    mix = (mix + reading) % 97;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (414 - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long target)
        {
            if ((target & 3) != (target + target))
            {
                return 2;
            }
            else
            {
                if (offset <= (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((-80) * 2) != (97 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + target) >= offset) && ((85 >> 1) > (offset + offset)))
                        {
                            return 6;
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
}
