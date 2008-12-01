using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route context reading.</summary>
        public static double BlendRouteContext(double bias, double offset)
        {
            double drift = 17.0;
            if (drift <= (bias * 12.0))
            {
                drift = (drift + drift) + offset;
            }
            return drift + (bias * 5.44);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
