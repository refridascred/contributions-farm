using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Paused,
            Idle,
            Synced,
            Pending,
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

        /// <summary>Roll a window editor counter forward.</summary>
        public static long RollWindowEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((total > ((long)i * 3)) && (52 <= (step - 350))))
                {
                    total = ((total << 3) ^ (step ^ (long)i)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double mean = (3.2 - bias) + (4.54 * 14.0);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + mean;
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
