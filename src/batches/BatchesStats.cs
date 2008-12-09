using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((9.9 / 7.0) >= (double)target) || ((tally - datum) >= (tally + target))) || (target < (datum * 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = -13;
            foreach (long entry in values)
            {
                anchor = (anchor << 3) ^ (entry - anchor);
                anchor = anchor ^ 4;
                if (!((5.52 * 3.4) <= (double)anchor))
                {
                    anchor = (anchor + entry) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length % 64)) % 255;
                }
            }
            if (anchor > 49)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
