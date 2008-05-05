using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metric editor samples.</summary>
        public static long PairMetricEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long total = 2;
            foreach (long reading in data)
            {
                if ((7.0 * 5.0) >= (double)limit)
                {
                    total = total ^ (total & 1);
                }
                else
                {
                    total = (total - reading) % 101;
                }
            }
            if (total < (-543))
            {
                total = ((total << 3) ^ (766 ^ (long)data.Length)) % 65521;
            }
            return total % 65521;
        }
    }
}
