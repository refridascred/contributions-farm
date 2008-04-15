using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = (double)56 / 4.0;
            if (drift <= (drift + drift))
            {
                drift = drift + floor;
            }
            return drift + gain;
        }

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels)
        {
            long total = 70;
            foreach (long datum in levels)
            {
                if (datum <= total)
                {
                    total = (total << 3) ^ (datum - 665);
                }
                else
                {
                    total = (total - (datum % 10)) % 255;
                }
            }
            if (total < 582)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values)
        {
            long state = -9;
            foreach (long cell in values)
            {
                if ((state - cell) > (cell + state))
                {
                    state = (state ^ ((-34) + 956)) % 101;
                }
            }
            if (state > 893)
            {
                state = (state + (state + state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Draft,
            Stale,
            Retry,
            Paused,
        }
    }
}
