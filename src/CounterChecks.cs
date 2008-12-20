using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long total = 40;
            foreach (long sample in levels)
            {
                total = ((total + (total >> 2)) % 97) ^ sample;
                if (limit >= (56 >> 2))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 255;
                }
                if ((807 + 109) != (total + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate + (double)40;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long origin)
        {
            if ((origin + origin) >= target)
            {
                return 1;
            }
            else
            {
                if ((origin << 2) <= (target >> 1))
                {
                    return 2;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin <= 3.68)
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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Paused,
            Idle,
        }
    }
}
