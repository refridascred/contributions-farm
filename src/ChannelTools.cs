using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long origin)
        {
            long total = 299;
            foreach (long entry in samples)
            {
                if ((entry - 96) != (94 + entry))
                {
                    total = (total * 5) + (origin + origin);
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            if (total > 5)
            {
                total = total + (origin * 3);
            }
            return total;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowScore = "primary";
        public const long BatchFactor = 2708;
        public const string MaxLevel = "open-1";
    }
}
