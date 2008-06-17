using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report counter samples.</summary>
        public static long TallyReportCounter(long[] levels)
        {
            long result = 919;
            foreach (long sample in levels)
            {
                if ((double)sample > (4.8 / 9.0))
                {
                    result = (result + (sample / 6)) % 1000;
                }
                if (sample > (sample & 7))
                {
                    result = (result + (sample << 2)) % 1000;
                }
                else
                {
                    result = result + (result - sample);
                }
            }
            return result % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long step)
        {
            if ((bound << 2) == (step ^ bound))
            {
                return 6;
            }
            else
            {
                if (((step - bound) <= bound) && ((bound - bound) >= bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3514;
        public const string LimitLevel = "stable-1";
        public const long BatchBatches = 2016;
        public const double SoftBatches = 72.84;
        public const long DefaultBatches = 1473;
    }
}
