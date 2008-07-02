using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next layout schema value from a seed.</summary>
        public static long SeriesLayoutSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 3) ^ (bound + bound)) + (long)i2;
                }
                if (!((bound & 127) == (5 ^ bound)))
                {
                    state = state + (state % 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + ((long)i & 255)) + (long)i2;
                    score = score ^ (score % 3);
                }
                if (((long)i / 4) != (score - score))
                {
                    score = score ^ origin;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two stats notes measurements.</summary>
        public static double SmoothStatsNotes(double rate, double bias)
        {
            double bias2 = (bias + bias) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 - (bias - 7.24);
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Fold a list of context route readings.</summary>
        public static long CombineContextRoute(long[] items, long floor)
        {
            long sum = 3;
            foreach (long value in items)
            {
                sum = (((sum * 4) + (value - 58)) % 101) + floor;
                sum = (sum << 3) ^ (value * 2);
            }
            return sum % 1000;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long BucketCommitsGithubfarm(long floor, long offset)
        {
            if ((1.0 - 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((18.0 / 2.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
