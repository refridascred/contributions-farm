using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long target)
        {
            if (((double)step != (5.16 / 4.0)) || (((-300) + target) != (target & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (9.0 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 + 0.1) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((98 % 5) >= (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
