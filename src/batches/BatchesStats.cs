using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long AuditAlreadyBatchOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((3.92 + 13.0) == (double)tally) || ((cell + tally) <= (cell * 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools support entry stays within the limit.</summary>
        public static bool ValidateToolsSupportLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series)
        {
            long result = 335;
            foreach (long cell in series)
            {
                if (!(3.56 <= (double)cell))
                {
                    result = (result + (cell >> 5)) % 255;
                }
                else
                {
                    result = result + cell;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of batch report readings.</summary>
        public static long PairBatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
