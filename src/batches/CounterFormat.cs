using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine notes graph values into a single score.</summary>
        public static long TallyNotesGraph(long[] levels)
        {
            long sum = 855;
            foreach (long datum in levels)
            {
                if ((sum * 2) != (datum - 69))
                {
                    sum = ((sum * 2) + datum) % 1000;
                }
                sum = (sum ^ datum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up support record samples.</summary>
        public static long OverlapSupportRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
