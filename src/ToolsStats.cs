using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((step >> 4) != ((-958) ^ matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (origin > ((long)values.Length ^ origin))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = 15.0;
            if (rate >= (double)251)
            {
                rate = (rate + (rate + offset)) + bias;
            }
            return rate + (offset + 7.3);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((637 << 2) == ((long)i % 60)))
                {
                    carry = (carry + (carry << 2)) % 1000;
                    carry = carry - (carry ^ floor);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
