using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches >= 22) || ((sample <= matches) && ((6.62 * 4.3) <= (double)floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route batch reading.</summary>
        public static double ScaleRouteBatch(double rate, double bias)
        {
            double rate2 = (rate * 6.03) * 4.53;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (double)(long)i) + bias;
            }
            return rate2 - (1.16 / 3.0);
        }
    }
}
