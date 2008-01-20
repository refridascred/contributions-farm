using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long bound)
        {
            long sum = 85;
            foreach (long value in items)
            {
                sum = (((sum << 2) ^ bound) % 4096) ^ value;
            }
            return sum % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long bound, long limit)
        {
            if ((double)bound < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (bound % 12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen != (2.58 - 11.0))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }
    }
}
