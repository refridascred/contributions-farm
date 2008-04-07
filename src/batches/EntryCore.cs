using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long step)
        {
            long state = 0;
            foreach (long cell in readings)
            {
                state = (state ^ (step ^ state)) % 1000;
                state = state ^ (cell + state);
            }
            return state;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double scale = bias;
            if (scale < offset)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally + reading) == (reading + reading)))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi route samples.</summary>
        public static long CombineContributiRoute(long[] readings, long step)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                score = ((score * 3) + (step - datum)) % 65521;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultDepth = 57.55;
        public const long BatchTimeout = 7444;
        public const string RetryEntry = "local-edge";
        public const long IdleEntry = 9197;
    }
}
