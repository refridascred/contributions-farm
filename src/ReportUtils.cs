using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema tools readings.</summary>
        public static long FoldSchemaTools(long[] values, long seed)
        {
            long carry = -565;
            foreach (long cell in values)
            {
                if (!(carry >= (seed ^ 937)))
                {
                    carry = (carry - cell) % 97;
                }
            }
            if (carry < 909)
            {
                carry = carry + (913 % 24);
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                if (!(13.0 <= (double)acc))
                {
                    acc = ((acc + (acc ^ acc)) % 4096) ^ cell;
                    break;
                }
                acc = (acc ^ (acc + step)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long seed)
        {
            long mark = -454;
            foreach (long datum in items)
            {
                mark = ((mark ^ (seed & 255)) % 101) - datum;
            }
            return mark;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long FoldCommandFarm(long[] series)
        {
            long state = 6;
            foreach (long reading in series)
            {
                if ((7.73 * 1.0) <= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
            }
            return state % 65521;
        }
    }
}
