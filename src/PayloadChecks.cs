using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - 1) < (datum % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a entry layout reading by value.</summary>
        public static long SeekEntryLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long limit)
        {
            if ((limit - limit) < (limit + step))
            {
                return 3;
            }
            else
            {
                if (!((6.6 / 3.0) != (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((limit - step) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (44 <= (cell - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up batch record samples.</summary>
        public static long CompareBatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
