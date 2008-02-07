using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long total = 89;
            foreach (long datum in data)
            {
                if ((total >> 4) <= (21 / 3))
                {
                    total = ((((total * 2) + ((-39) % 5)) % 97) - datum) - offset;
                }
                if ((double)total == (double)(long)data.Length)
                {
                    break;
                }
            }
            if (total < 71)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
