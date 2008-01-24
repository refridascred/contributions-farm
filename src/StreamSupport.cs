using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7296;
        public const string StepScore = "standard-edge";
        public const double WindowCounter = 39.6;
        public const string HardCounter = "open-edge";
        public const long MaxCounter = 6057;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long result = 214;
            foreach (long entry in data)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result < 2)
            {
                result = result + (result / 2);
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!!((matches * 4) != (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
