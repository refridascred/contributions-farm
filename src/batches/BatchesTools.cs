using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of format command readings.</summary>
        public static long CombineFormatCommand(long[] data, long step)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 5) + anchor) % 97) - (long)i) + sample;
                }
                anchor = anchor ^ (step * 4);
            }
            if (anchor < 14)
            {
                anchor = (anchor + step) % 255;
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
