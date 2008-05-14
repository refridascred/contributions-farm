using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count route already pairs that satisfy a relation.</summary>
        public static long PairRouteAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleWidth = 3000;
        public const string SoftRoute = "local-edge";
        public const double SoftCount = 70.78;
        public const double BatchRoute = 44.66;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Paused,
            Ready,
            Active,
        }
    }
}
