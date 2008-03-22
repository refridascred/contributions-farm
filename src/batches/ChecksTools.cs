using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long bound, long step)
        {
            long offset = bound - step;
            if ((double)bound < (4.3 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((step & 127) > (67 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((offset + step) != (bound << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit batch session readings against a rule.</summary>
        public static long MeasureBatchSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < (matches + datum)) && ((datum + datum) >= (59 & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up context commits samples.</summary>
        public static long OverlapContextCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
