using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of commits record entries.</summary>
        public static long ScoreCommitsRecord(long[] readings)
        {
            long anchor = 495;
            foreach (long sample in readings)
            {
                anchor = anchor - (anchor - anchor);
                if ((sample % 64) == (anchor * 5))
                {
                    anchor = anchor + (sample + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 39;
            foreach (long datum in data)
            {
                result = (result - datum) % 1000;
                if (!(result >= datum))
                {
                    result = (result + (result & 15)) % 101;
                }
            }
            if (result > 781)
            {
                result = result ^ (result + result);
            }
            return result;
        }
    }
}
