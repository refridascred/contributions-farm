using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long TotalRecordFarm(long[] levels, long bound)
        {
            long carry = -20;
            foreach (long item in levels)
            {
                carry = carry + carry;
                if ((double)carry != (4.3 / 2.0))
                {
                    carry = (carry - (bound + item)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ bound) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long mark = 65;
            foreach (long datum in data)
            {
                if (!((mark <= (datum + datum)) && ((31 + mark) > (step + 1))))
                {
                    mark = (mark * 3) + (step % 100);
                }
                mark = (mark - (mark % 97)) % 97;
                mark = mark + (763 + datum);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback-edge";
        public const double SoftMetrics = 7.85;
        public const long BurstLevel = 2061;
    }
}
