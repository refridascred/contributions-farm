using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the schema window series from a seed.</summary>
        public static long IterateSchemaWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items, long step)
        {
            long acc = 518;
            foreach (long value in items)
            {
                if ((value - (-484)) >= (acc ^ acc))
                {
                    acc = acc + (acc + value);
                }
                if (((value & 63) < (step * 2)) && (step > value))
                {
                    acc = ((acc * 4) + ((-758) ^ step)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool VerifyBatchSchemaRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
