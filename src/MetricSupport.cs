using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5748;
        public const long DefaultFilter = 4913;
        public const string WindowRatio = "strict-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1984;
        public const long WindowSize = 1079;
        public const double HardQueue = 42.57;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long floor)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if ((floor % 64) == (acc + reading))
                {
                    acc = acc + (acc - 24);
                }
                else
                {
                    acc = acc + (long)values.Length;
                }
            }
            return acc;
        }
    }
}
