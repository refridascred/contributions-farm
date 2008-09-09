using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long ClassifySchemaBuffer(long step, long step2)
        {
            if (!((0.5 * 6.6) >= (double)step))
            {
                return 8;
            }
            else
            {
                if ((step2 / 9) < ((-9) - step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step2) <= (step2 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) <= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double drift = (double)481 / 5.0;
            if (drift <= (bias - drift))
            {
                drift = drift - (drift + drift);
            }
            return drift + floor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long seed)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if (!((double)27 < (double)sample))
                {
                    score = score ^ 537;
                }
                else
                {
                    score = ((score * 5) + ((-63) - (long)readings.Length)) % 65521;
                    score = (score ^ seed) % 97;
                }
                score = score ^ score;
                if ((sample + (-713)) < sample)
                {
                    score = score + (score - score);
                }
            }
            return score % 65521;
        }
    }
}
