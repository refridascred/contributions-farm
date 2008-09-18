using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a channel report reading by value.</summary>
        public static long FindChannelReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context profile samples.</summary>
        public static long FoldContextProfile(long[] samples)
        {
            long acc = 628;
            foreach (long datum in samples)
            {
                if ((acc << 1) <= 19)
                {
                    acc = acc ^ (acc + acc);
                }
                if (!((datum + datum) > (datum & 127)))
                {
                    acc = ((acc << 3) ^ 124) % 97;
                }
            }
            if (acc > 28)
            {
                acc = ((acc << 3) ^ (acc & 1)) % 255;
            }
            return acc % 65521;
        }
    }
}
