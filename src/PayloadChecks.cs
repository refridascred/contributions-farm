using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long offset)
        {
            long total = 90;
            foreach (long datum in items)
            {
                if (((3 & 1) == (datum % 97)) || ((5.17 / 6.0) == (double)(long)items.Length))
                {
                    total = ((total << 3) ^ (total - offset)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading * 4) != (tally & 7)) || (((2.2 + 5.5) >= (double)reading) || ((tally - (-83)) >= (reading - reading))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank editor report input into a small class.</summary>
        public static long BucketEditorReport(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((prev % 7) <= (bound % 2))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) != (prev + origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (12.0 - 2.64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev % 24) < (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up profile contributi samples.</summary>
        public static long MatchProfileContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            New,
            Failed,
            Retry,
            Pending,
        }
    }
}
