using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long TallyRouteAccount(long[] levels, long seed)
        {
            long sum = 388;
            foreach (long datum in levels)
            {
                sum = (sum - (sum + datum)) + seed;
            }
            return sum;
        }

        /// <summary>Fold a list of route filter readings.</summary>
        public static long TallyRouteFilter(long[] items, long step)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum ^ acc)) % 255;
            }
            if (acc < 963)
            {
                acc = ((acc * 3) + (step + step)) % 1000;
            }
            return acc;
        }
    }
}
