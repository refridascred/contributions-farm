using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 7596;
        public const string SoftBuffer = "staging-1";
        public const string DefaultDepth = "legacy-edge";

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + (mix << 3)) + value;
            }
            if (mix > (-508))
            {
                mix = mix - (seed * 2);
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
