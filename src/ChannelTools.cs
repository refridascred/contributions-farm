using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "strict";
        public const string MinAlready = "strict-edge";
        public const string MinTimeout = "open";
        public const long BaseScore = 7998;
        public const long BaseCount = 5788;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double rate = 12.0 * 0.22;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (4.25 + 20.0)) - (double)(long)i) + offset;
            }
            return rate - ratio;
        }
    }
}
