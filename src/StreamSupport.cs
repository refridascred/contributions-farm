using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 3340;
        public const long WindowCounter = 5978;
        public const long BatchCounter = 3436;
        public const string StepBudget = "strict-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "strict-v2";
        public const string CacheFactor = "legacy-1";
        public const long BurstScore = 3544;
        public const long DefaultOrder = 3410;
        public const long BurstOrder = 456;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((floor + target) >= (target - target)))
            {
                return 3;
            }
            else
            {
                if (65 >= (target << 3))
                {
                    return 8;
                }
                else
                {
                    if ((470 & 63) >= (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > 8.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
