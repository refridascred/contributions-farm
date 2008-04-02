using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long score = -1;
            foreach (long datum in samples)
            {
                score = (score ^ (2 * 5)) + datum;
            }
            if (score < 1)
            {
                score = (score - (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long step2)
        {
            long delta = step ^ step2;
            if (step2 >= (6 * 5))
            {
                return 6;
            }
            else
            {
                if ((double)step > (double)step2)
                {
                    return 0;
                }
                else
                {
                    if ((step2 - delta) > delta)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step != (2.0 - 7.8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long anchor = 263;
            foreach (long datum in readings)
            {
                if (((double)origin >= (9.6 + 5.4)) || ((origin ^ 854) >= (datum + 404)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }
    }
}
