using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleInterval = 879;
        public const double WindowFarm = 97.25;
        public const long BatchFarm = 8208;
        public const double IdleFarm = 86.56;

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 4774;
        public const long IdleSchema = 2534;
        public const long MinSchema = 2223;
        public const long BatchWidth = 679;
        public const string WindowTimeout = "local-1";
    }
}
