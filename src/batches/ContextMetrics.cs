using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long AuditLayoutOrderGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((bound + 152) <= seen) && ((bound + 84) != (bound % 5)))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch command samples.</summary>
        public static long CombineBatchCommand(long[] series)
        {
            long sum = 891;
            foreach (long cell in series)
            {
                sum = (((sum << 2) ^ (956 % 97)) % 101) - cell;
            }
            if (sum < 3)
            {
                sum = sum ^ (sum * 2);
            }
            return sum;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                long delta = mark ^ (floor + mark);
                if (((delta & 63) > (delta >> 3)) || (94 < (mark * 2)))
                {
                    mark = (mark - (mark + delta)) % 101;
                    continue;
                }
                delta = (delta + (mark & 255)) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
