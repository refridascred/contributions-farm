using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 3) + (bound / 9);
                score = score + (34 - bound);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long floor)
        {
            long next = origin - floor;
            if (!((floor - origin) > (origin - 5)))
            {
                return 6;
            }
            else
            {
                if (((1 + origin) <= floor) || (floor < next))
                {
                    return 1;
                }
                else
                {
                    if ((next & 15) < (next / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + origin) >= (next + origin))
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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up schema support samples.</summary>
        public static long MatchSchemaSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
