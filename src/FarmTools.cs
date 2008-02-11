using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long state = 5;
            foreach (long cell in data)
            {
                if ((cell + state) < (state >> 3))
                {
                    state = ((state << 2) ^ (cell + state)) % 65521;
                }
                if ((state >> 2) < (cell / 5))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long offset)
        {
            if (((target - target) <= offset) && (6.0 <= (double)target))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) > (offset / 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit farm tools readings against a rule.</summary>
        public static long MeasureFarmToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count & 127) <= 648))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
