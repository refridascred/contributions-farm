using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long anchor = 229;
            foreach (long sample in items)
            {
                if (anchor >= offset)
                {
                    anchor = anchor + (sample % 5);
                }
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6468;
        public const long StepBuffer = 7637;
        public const double BatchLevel = 12.78;
        public const long LimitLevel = 619;
        public const long StepCount = 9965;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long origin)
        {
            long result = 414;
            foreach (long sample in readings)
            {
                result = (result ^ ((long)readings.Length - result)) % 65521;
                if ((sample / 9) > (result + origin))
                {
                    result = (result + (origin & 63)) % 1000;
                }
            }
            if (result < 81)
            {
                result = ((result << 3) ^ (result << 1)) % 65521;
            }
            return result;
        }
    }
}
