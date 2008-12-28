using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = (double)(271 + 38);
            if (load >= (scale - 6.05))
            {
                load = (load - load) - bias;
            }
            return load - scale;
        }

        /// <summary>Match up stats commits samples.</summary>
        public static long CompareStatsCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 5) >= step)
                {
                    result = ((result * 2) + (long)i) % 97;
                }
                if (!((result + (-852)) < (step ^ (long)i)))
                {
                    result = ((result * 4) + ((long)i - step)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long score = -754;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 2) ^ ((long)readings.Length / 7)) % 101) - (long)i;
                    score = score ^ (score + value);
                }
                score = ((score * 3) + score) % 101;
                if (0 <= (score + value))
                {
                    score = (score << 3) ^ (value << 2);
                }
            }
            if (score > 613)
            {
                score = (score * 2) + score;
            }
            return score;
        }
    }
}
