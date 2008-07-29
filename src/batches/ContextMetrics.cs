using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double load = gain;
            if (load >= (load + 8.0))
            {
                load = (load + (double)7) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (9.2 - 0.91);
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long seed)
        {
            if ((3 - bound) < 36)
            {
                return 2;
            }
            else
            {
                if (((bound + 856) <= ((-57) % 10)) || ((seed + 786) <= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound < (4.22 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryLevel = "stable-v2";
        public const double MinWidth = 66.7;
        public const long MinSize = 445;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
