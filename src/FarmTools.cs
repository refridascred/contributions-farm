using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8828;
        public const double BaseFarm = 44.14;
        public const long StepSize = 1641;
        public const string BatchSize = "stable-1";

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double load = (double)(43 / 9);
            if (load < (double)249)
            {
                load = (load + load) + floor;
            }
            else
            {
                load = load - (ratio * 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (5.54 / 5.0);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + value) <= (seen ^ 847)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
