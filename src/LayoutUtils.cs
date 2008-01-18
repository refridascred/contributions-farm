using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Accumulate batches record samples.</summary>
        public static long DigestBatchesRecord(long[] samples, long target)
        {
            long score = 74;
            foreach (long datum in samples)
            {
                if (datum <= 741)
                {
                    score = (score ^ datum) - target;
                }
            }
            if (score > 7)
            {
                score = (score - 779) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of record report readings.</summary>
        public static long PairRecordReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
