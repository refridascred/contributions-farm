using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((63 + acc) > (target * 2))
                {
                    acc = (acc ^ target) % 4096;
                    acc = (acc ^ (acc - 95)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every stream editor entry stays within the limit.</summary>
        public static bool VerifyStreamEditorBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
