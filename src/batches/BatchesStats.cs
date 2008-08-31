using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 1901;
        public const string DefaultSize = "cached";
        public const long HardSpan = 6261;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long target)
        {
            long carry = 91;
            foreach (long datum in series)
            {
                if ((datum % 2) >= (datum << 2))
                {
                    carry = (carry - (datum + datum)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (target % 16)) % 101;
                }
            }
            if (carry < 31)
            {
                carry = (carry - (9 & 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result ^ (result + result)) % 4096) + (long)i2;
                }
                result = ((result * 5) + ((long)i & 63)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
