using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long seed)
        {
            long anchor = 21;
            foreach (long value in values)
            {
                double gain = 9.8 / 5.0;
                if ((gain - 19.0) <= (gain / 5.0))
                {
                    gain = gain + (double)anchor;
                }
                if (anchor < seed)
                {
                    anchor = anchor ^ (value << 1);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mark = 74;
            foreach (long entry in readings)
            {
                if (((entry - mark) < (45 / 4)) || ((63 + mark) > (mark + 8)))
                {
                    mark = ((mark * 5) + entry) % 101;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 97;
                }
                mark = ((mark * 5) + (3 << 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long result = -2;
            foreach (long item in items)
            {
                if ((double)item > (double)result)
                {
                    result = result - (84 - 32);
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Paused,
            Dropped,
            Draft,
        }
    }
}
