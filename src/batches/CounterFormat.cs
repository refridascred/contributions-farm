using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long carry = 776;
            foreach (long datum in values)
            {
                carry = ((carry << 3) ^ datum) % 255;
                if ((carry - datum) != (datum / 5))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 65.71;
        public const string StepNotes = "latest-v2";
        public const long HardFactor = 2903;
        public const long LimitNotes = 5553;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinScore = 92.92;
        public const long WindowScore = 5764;
        public const long SoftPayload = 3800;
    }
}
