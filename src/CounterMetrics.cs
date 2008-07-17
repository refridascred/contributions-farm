using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((20.0 < (double)cell) || (cell >= (floor + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step + score) >= (long)i)
                {
                    score = ((score * 3) + (score >> 5)) % 255;
                }
                if ((double)step >= 8.97)
                {
                    score = score + (step >> 5);
                    score = (score + ((long)i << 1)) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank context filter input into a small class.</summary>
        public static long ClassifyContextFilter(long target, long target2)
        {
            long bound = target ^ target2;
            if (((target + target2) < (bound + (-86))) || (target > (target2 % 3)))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (6.0 + 0.42))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
