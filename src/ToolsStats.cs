using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool VerifySessionSchemaBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if ((value >> 5) > value)
                {
                    mix = ((mix << 3) ^ mix) + floor;
                }
            }
            return mix;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double mean = (double)(25 & 7);
            if (mean < (double)17)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (5.0 + gain)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if (!((item >> 1) >= (state << 2)))
                {
                    state = state + (state + item);
                }
                else
                {
                    state = ((state * 2) + 0) % 97;
                    state = (state ^ (state + item)) % 1000;
                }
                state = (state + (state + item)) % 255;
                if ((state * 4) < (63 >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
