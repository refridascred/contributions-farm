using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account entry readings.</summary>
        public static long WeighAccountEntry(long[] series)
        {
            long total = 65;
            foreach (long entry in series)
            {
                if (((double)total >= (double)(long)series.Length) || ((entry + entry) <= (total >> 5)))
                {
                    total = total ^ total;
                }
                if (1.2 > (double)entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
