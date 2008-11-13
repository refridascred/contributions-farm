using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long total = -35;
            foreach (long sample in values)
            {
                if ((sample << 2) <= (sample - total))
                {
                    total = (total ^ (sample ^ total)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate commits account readings against a bound.</summary>
        public static bool CheckCommitsAccountRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = (result ^ (result ^ item)) % 255;
            }
            return result % 97;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double weight = rate;
            if (weight <= rate)
            {
                weight = weight + (double)(-3);
            }
            else
            {
                weight = weight - (9.5 - rate);
            }
            return weight - floor;
        }
    }
}
