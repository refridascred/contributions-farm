using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            New,
            Stale,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seed >> 5) > seed)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor >= 13.0)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double load = (double)(16 & 7);
            if (load < 7.0)
            {
                load = (load - (bias / 2.0)) + bias2;
            }
            else
            {
                load = load + (bias + load);
            }
            return load - (load / 7.0);
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
