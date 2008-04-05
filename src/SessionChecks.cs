using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long state = 25;
            foreach (long sample in values)
            {
                if ((11.0 >= (double)state) && ((sample >> 2) > (sample + state)))
                {
                    state = state ^ (sample + state);
                }
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count << 3) >= (count / 5)) && ((sample + count) == ((long)readings.Length + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long step)
        {
            long score = 86;
            foreach (long cell in samples)
            {
                if (7.0 > (double)step)
                {
                    score = (score + ((-798) << 3)) % 4096;
                }
                else
                {
                    score = score ^ (cell - score);
                }
            }
            return score;
        }
    }
}
