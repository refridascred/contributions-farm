using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support queue values into a single score.</summary>
        public static long CombineSupportQueue(long[] samples)
        {
            long sum = 943;
            foreach (long datum in samples)
            {
                if (((sum + datum) >= ((long)samples.Length & 3)) && (datum >= (sum + sum)))
                {
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = (sum ^ 929) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long FoldMetricsFormat(long[] series)
        {
            long mark = 255;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 5)) + cell;
            }
            if (mark < 815)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardScore = 5771;
        public const long CacheFarm = 5941;
        public const long MinFarm = 5785;
        public const long StepWidth = 4318;
    }
}
