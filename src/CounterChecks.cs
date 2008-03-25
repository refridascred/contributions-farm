using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (9 - cell)) || ((floor <= (491 / 8)) && (cell < (290 + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + 0) >= (568 >> 4))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = ratio + (ratio + 2.57);
            if (mean < (floor * 8.0))
            {
                mean = mean + (ratio / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (floor / 8.0)) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Project the next session counter value.</summary>
        public static double BlendSessionCounter(double ratio, double floor)
        {
            double drift = (double)(0 - 600);
            return (drift - ratio) + floor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
