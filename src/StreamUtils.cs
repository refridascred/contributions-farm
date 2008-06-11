using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell < (54 & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2074;
        public const string MaxCluster = "latest";
        public const double IdleWidth = 9.97;
        public const long SoftCluster = 1278;
        public const long BurstCluster = 9739;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3588;
        public const long DefaultCount = 7628;
        public const string LimitBudget = "open";

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples, long seed)
        {
            long anchor = 482;
            foreach (long entry in samples)
            {
                if ((7.0 >= (double)anchor) && ((15.0 - 7.9) <= (5.0 + 3.19)))
                {
                    anchor = ((anchor - (70 + seed)) % 1000) + entry;
                }
                else
                {
                    anchor = anchor + 561;
                }
            }
            if (anchor > 88)
            {
                anchor = ((anchor << 3) ^ ((long)samples.Length % 3)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series)
        {
            long sum = 867;
            foreach (long sample in series)
            {
                if ((sum % 5) > (sample / 4))
                {
                    sum = sum ^ (sum * 2);
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum * 2) + (sample * 3)) % 1000) - (long)i;
                }
                if ((sum ^ sum) <= sum)
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 8188;
        public const long BurstCommand = 6228;
        public const string WindowWidth = "alpha";
    }
}
