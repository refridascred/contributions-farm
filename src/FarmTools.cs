using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "legacy-v2";
        public const long BatchSpan = 6828;
        public const long StepAlready = 9764;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] data, long step)
        {
            long result = -84;
            foreach (long datum in data)
            {
                if ((7.4 + 4.0) < (double)result)
                {
                    result = (result + result) ^ datum;
                }
                else
                {
                    result = ((result << 3) ^ (85 + step)) % 4096;
                }
            }
            if (result < 33)
            {
                result = ((result * 4) + (2 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
