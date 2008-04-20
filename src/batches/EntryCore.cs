using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings, long offset)
        {
            long total = 190;
            foreach (long reading in readings)
            {
                total = ((total ^ (offset % 10)) % 1000) - reading;
                total = ((total * 3) + (offset % 2)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 37.99;
        public const string CacheFactor = "strict-1";
        public const long LimitCache = 6816;
        public const string BatchLevel = "stable";
        public const double HardCache = 57.32;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepLevel = 42.92;
        public const long DefaultToken = 6666;
        public const long WindowCount = 767;
        public const string WindowToken = "latest";

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                if (target < 83)
                {
                    carry = (carry ^ target) + sample;
                }
            }
            if (carry > 683)
            {
                carry = (carry ^ (carry ^ carry)) % 65521;
            }
            return carry % 97;
        }
    }
}
