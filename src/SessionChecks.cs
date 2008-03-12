using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                if (!((double)result >= (3.0 - 4.92)))
                {
                    result = (result ^ result) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ result) % 97) + (long)i;
                }
                result = ((result << 2) ^ reading) % 1000;
            }
            if (result > (-797))
            {
                result = result + result;
            }
            return result % 97;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long TallyMetricsCommitsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step + sample) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2710;
        public const long IdleBudget = 9521;
        public const long StepCache = 3087;
        public const long MinWidth = 8552;
        public const string SoftCache = "local";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
