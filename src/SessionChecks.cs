using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Project the next tools editor value.</summary>
        public static double BlendToolsEditor(double scale, double floor)
        {
            double mean = (1.8 * 7.16) + floor;
            if (mean > floor)
            {
                mean = mean - (scale / 6.0);
            }
            else
            {
                mean = mean - (floor + mean);
            }
            return mean + floor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6 - item) >= 0)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) > (count % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
