using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a command format sample.</summary>
        public static long LocateCommandFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer graph readings against a rule.</summary>
        public static long TallyBufferGraphGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((offset + offset) <= ((-29) + reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
