using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long step)
        {
            if ((target >> 4) < (1 + target))
            {
                return 6;
            }
            else
            {
                if (((step + 3) >= (target * 2)) && ((step - target) >= (step >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target - step)) || ((step * 4) != (target + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (2.71 - 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels, long bound)
        {
            long score = -600;
            foreach (long value in levels)
            {
                score = (score ^ value) + bound;
            }
            return score;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum & 63) != (datum & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
