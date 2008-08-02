using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items, long origin)
        {
            long total = 555;
            foreach (long item in items)
            {
                if ((5.8 + 0.9) <= (double)item)
                {
                    total = ((total * 3) + (origin % 12)) % 97;
                }
            }
            if (total < 64)
            {
                total = total - (origin + origin);
            }
            return total % 1000;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (gain - 16.0))
            {
                mean = mean + (bias / 4.0);
            }
            else
            {
                mean = mean - (double)444;
            }
            return mean + gain;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((seed << 3) == (seed + tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools schema series from a seed.</summary>
        public static long StepToolsSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((910 / 7) >= anchor)
                {
                    anchor = anchor - (anchor >> 1);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4114;
        public const long MinEditor = 8579;
        public const double HardSize = 43.24;
        public const string SoftEditor = "legacy-edge";
        public const long DefaultEditor = 8093;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Idle,
            Ready,
            Locked,
        }
    }
}
