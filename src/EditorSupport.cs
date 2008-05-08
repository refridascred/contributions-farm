using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next contributi checks value from a seed.</summary>
        public static long DeriveContributiChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state << 3) ^ (state * 5);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long DerivePayloadStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (state >> 5)) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double ratio = (offset * 18.0) - (3.07 - 6.3);
            if (ratio <= (offset / 6.0))
            {
                ratio = ratio + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long bound)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state ^ (bound << 3)) % 101;
                if (((cell + bound) > 113) && (70 < (state << 3)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
