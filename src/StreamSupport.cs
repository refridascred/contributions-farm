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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) != (83 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
