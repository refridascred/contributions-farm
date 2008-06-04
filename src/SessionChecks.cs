using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((offset ^ 869) >= (7 ^ entry)) && ((entry > (tally + tally)) && (28 <= offset)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 2) + (step % 3);
                if ((step > (step - (long)i)) || ((double)step > (9.0 * 6.47)))
                {
                    state = ((state * 2) + (state + 825)) % 1000;
                }
                else
                {
                    state = (state ^ (step & 15)) % 255;
                    state = state + step;
                }
                state = ((state * 4) + ((long)i + state)) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (offset / 2.0)) + (double)(long)i;
            }
            return scale + (double)97;
        }
    }
}
