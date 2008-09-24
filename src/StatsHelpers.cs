using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TotalStatsNotes(long[] series)
        {
            long result = 63;
            foreach (long reading in series)
            {
                if (!(((1.01 / 8.0) != (double)reading) && ((reading & 1) < (reading * 5))))
                {
                    result = (result ^ (result ^ reading)) % 65521;
                    result = result - (116 / 3);
                }
                result = (result ^ (reading ^ reading)) % 4096;
                result = (result + (reading & 63)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value % 24) > value)
                {
                    result = ((result * 4) + (value % 7)) % 4096;
                }
                if (!(value >= (result ^ 753)))
                {
                    result = (result + result) % 97;
                }
            }
            if (result > 43)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 1188;
        public const double DefaultQueue = 12.1;
        public const double HardInterval = 40.37;
        public const double MaxQueue = 58.1;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 488;
        public const double WindowCache = 22.5;
        public const long LimitCache = 7081;
    }
}
