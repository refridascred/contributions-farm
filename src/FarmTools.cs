using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            long edge = target + target2;
            if (target <= (target2 - 753))
            {
                return 1;
            }
            else
            {
                if ((edge & 7) < 82)
                {
                    return 2;
                }
                else
                {
                    if (!((edge << 2) <= edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (7.5 * 2.7))
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
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6063;
        public const double MinRatio = 74.39;
        public const long BurstFactor = 5965;
        public const long StepBatches = 3153;
        public const long SoftBatches = 1319;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long total = 82;
            foreach (long datum in samples)
            {
                if (total >= ((long)samples.Length + (-3)))
                {
                    total = total ^ (datum & 63);
                }
            }
            if (total < 25)
            {
                total = (total + (total << 2)) % 101;
            }
            return total;
        }
    }
}
