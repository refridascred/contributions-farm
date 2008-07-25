using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Idle,
            Done,
            Active,
            Stale,
        }

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
