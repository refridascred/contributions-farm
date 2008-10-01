using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Done,
            New,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc << 3) ^ cell;
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 24);
            }
            return acc;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
