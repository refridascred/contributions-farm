using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long AuditFormatCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 2) >= (tally & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long mark = 62;
            foreach (long entry in values)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 101) + entry;
            }
            return mark;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
