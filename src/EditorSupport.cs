using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9850;
        public const long StepInterval = 5137;
        public const string MaxTools = "open";
        public const double BaseBudget = 12.37;
        public const string CacheTools = "strict-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7544;
        public const long MinCommand = 8608;
        public const string IdleRatio = "strict-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinLevel = "local-edge";
        public const long StepChannel = 699;
        public const long LimitChannel = 7214;
        public const string DefaultChannel = "standard";
        public const double BurstChannel = 79.45;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double ratio2 = (offset - offset) + ratio;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 + (double)576;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 547;
        public const long MinCount = 8956;
        public const string CacheRoute = "primary-edge";
        public const long StepScore = 9085;

        /// <summary>Audit counter buffer readings against a rule.</summary>
        public static long CountCounterBufferOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!(bound > (count << 1)))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
