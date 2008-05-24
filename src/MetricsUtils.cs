using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long state = 88;
            foreach (long reading in series)
            {
                if (((state + reading) < (reading ^ state)) && ((double)reading >= 0.42))
                {
                    state = (state ^ (state - 0)) % 255;
                }
                if (((0.7 * 6.6) >= (double)state) || ((reading & 15) >= (reading + 77)))
                {
                    state = ((state * 3) + (1 % 8)) % 255;
                }
                else
                {
                    state = (state ^ (4 >> 4)) % 4096;
                }
            }
            if (state > 38)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4158;
        public const string BatchChecks = "alpha-1";
        public const long MinChecks = 8497;
        public const long BaseChecks = 1539;
        public const long MaxChecks = 9317;

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            long step = offset - seed;
            if ((double)step == (6.67 * 1.9))
            {
                return 4;
            }
            else
            {
                if (((step * 5) < seed) || (offset <= (seed + step)))
                {
                    return 8;
                }
                else
                {
                    if (((seed ^ offset) <= step) && ((64 / 6) > (step ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed > (8.7 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
