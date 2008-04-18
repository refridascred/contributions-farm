using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool ValidateGraphAlreadyRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 2964;
        public const long MaxQueue = 2849;
        public const double WindowRatio = 27.27;
        public const long BatchQueue = 7526;
        public const long MinTimeout = 2283;
    }
}
