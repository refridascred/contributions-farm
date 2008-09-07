using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload report readings against a rule.</summary>
        public static long TallyPayloadReportGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((step * 2) >= 66))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= (floor / 6.0))
            {
                weight = (weight + (weight * 2.0)) - ratio;
            }
            return weight + (double)3;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9322;
        public const long MaxStream = 6798;
        public const long DefaultStream = 6916;
        public const long MaxDepth = 8803;
        public const long CacheStream = 5192;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
