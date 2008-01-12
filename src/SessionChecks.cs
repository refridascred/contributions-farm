using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a already schema counter forward.</summary>
        public static long IterateAlreadySchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long CacheRatio = 9646;
        public const long BaseFarm = 7047;
        public const double BurstFarm = 40.51;

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double weight = (double)43 - offset;
            if (weight <= (13.0 + offset))
            {
                weight = weight + (scale * 1.1);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - (offset + scale);
        }
    }
}
