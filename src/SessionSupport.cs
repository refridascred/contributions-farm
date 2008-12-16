using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mix = 880;
            foreach (long item in values)
            {
                mix = ((mix * 4) + (item & 31)) - limit;
            }
            return mix;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((9.53 / 4.0) < (double)floor)
                {
                    result = (result + (floor & 31)) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }
    }
}
