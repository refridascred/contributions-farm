using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double rate = scale + (6.6 / 9.0);
            return (rate - rate) + offset;
        }

        /// <summary>Audit contributi context readings against a rule.</summary>
        public static long MeasureContributiContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count - cell) >= (cell % 8)) || ((count - count) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
