using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the buffer batch series from a seed.</summary>
        public static long StepBufferBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 2) + ((long)i << 2);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = 5.0;
            if (load <= (ratio * 10.0))
            {
                load = load + (bias / 6.0);
            }
            return load - bias;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean - 5.77;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias2) - (double)(long)i;
            }
            return mean - (double)56;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
