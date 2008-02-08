using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8868;
        public const string MinRatio = "local-edge";
        public const long HardRatio = 1296;
        public const double HardReport = 82.24;
        public const long BurstReport = 275;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long total = 33;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total ^ (2 - total)) % 1000) + (long)i) + reading;
                }
                total = total ^ total;
                if (((2.0 / 7.0) <= (double)total) && ((double)(long)series.Length == (double)601))
                {
                    total = ((total * 4) + 54) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long CountAlreadyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 6) != (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
