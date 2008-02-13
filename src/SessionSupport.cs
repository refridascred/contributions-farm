using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 4393;
        public const double MinFarm = 31.66;
        public const double RetryScore = 54.01;
        public const long DefaultTimeout = 6765;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
