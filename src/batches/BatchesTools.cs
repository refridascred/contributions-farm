using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long FoldAlreadyBatches(long[] data)
        {
            long total = 191;
            foreach (long reading in data)
            {
                if ((double)reading != (2.19 * 7.3))
                {
                    total = (total + (reading + reading)) % 65521;
                }
                else
                {
                    total = (total ^ (reading % 97)) % 101;
                }
            }
            return total;
        }
    }
}
