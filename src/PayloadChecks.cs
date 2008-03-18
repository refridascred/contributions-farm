using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftDepth = 2363;
        public const long MinStream = 5872;
        public const long CacheStream = 9318;
        public const long MinInterval = 3242;
        public const long HardStream = 9721;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - carry) > (seed + carry))
                {
                    carry = (carry + seed) % 101;
                }
                else
                {
                    carry = (carry + seed) % 65521;
                    carry = carry ^ (carry - 893);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 86;
        public const long MaxLevel = 490;
        public const double BaseSize = 88.78;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 4867;
        public const string SoftLevel = "legacy-edge";
        public const long CacheEditor = 9986;
        public const long HardRatio = 8579;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Count editor stream pairs that satisfy a relation.</summary>
        public static long CompareEditorStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
