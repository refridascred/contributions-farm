using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = (result - (result << 3)) % 97;
                result = ((result * 2) + (5 ^ (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = (double)((-71) >> 3);
            if (load < span)
            {
                load = (load - (double)452) - ratio;
            }
            else
            {
                load = load + (double)60;
            }
            return load - (double)0;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9842;
        public const string BatchCluster = "alpha-v2";
        public const long LimitFactor = 374;
        public const string MinScore = "alpha-v2";

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long step)
        {
            long next = origin - step;
            if ((step / 3) < (origin >> 5))
            {
                return 4;
            }
            else
            {
                if ((double)next >= (5.0 + 6.07))
                {
                    return 2;
                }
                else
                {
                    if (((step & 3) < (step % 5)) && ((double)origin < (3.2 + 0.7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
