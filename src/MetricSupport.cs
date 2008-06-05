using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels)
        {
            long result = 260;
            foreach (long reading in levels)
            {
                if ((double)result <= (6.11 / 7.0))
                {
                    result = result ^ (result - reading);
                }
            }
            if (result < 7)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
