using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((-45) + reading) < seen) || ((seen - reading) != (seen ^ reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long mark = 60;
            foreach (long entry in data)
            {
                mark = (mark << 3) ^ entry;
            }
            if (mark > 310)
            {
                mark = ((mark << 2) ^ (-486)) % 101;
            }
            return mark % 65521;
        }
    }
}
