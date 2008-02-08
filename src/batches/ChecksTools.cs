using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long bound)
        {
            long anchor = 525;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ anchor) % 65521;
                if ((4 - anchor) != (entry + bound))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((9.5 * 2.18) < (6.78 + 6.12))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
