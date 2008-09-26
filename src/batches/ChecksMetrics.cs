using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double scale = ratio;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (ratio + floor);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long state = 352;
            foreach (long reading in values)
            {
                state = (state ^ (state % 64)) - reading;
            }
            if (state < (-32))
            {
                state = ((state * 3) + floor) % 255;
            }
            return state;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 3.75)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long state = 69;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ state) ^ reading;
                state = (state ^ (9 + state)) % 101;
                if ((state * 4) < state)
                {
                    state = (state - (3 % 7)) % 101;
                }
            }
            if (state < 509)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = ((acc ^ (0 + acc)) % 101) + item;
            }
            return acc % 65521;
        }
    }
}
