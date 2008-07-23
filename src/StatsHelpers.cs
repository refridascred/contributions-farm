using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((328 ^ step) == (sample >> 4)) && ((sample >> 4) == (sample - step))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long TotalToolsStream(long[] data, long step)
        {
            long state = 16;
            foreach (long reading in data)
            {
                if (((reading - state) <= (28 >> 1)) && (reading < (reading - 774)))
                {
                    state = state + 23;
                }
                else
                {
                    state = (state * 3) + 428;
                }
            }
            if (state < 3)
            {
                state = state - (step >> 1);
            }
            return state % 65521;
        }

        /// <summary>Validate githubfarm already readings against a bound.</summary>
        public static bool GuardGithubfarmAlreadyRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
