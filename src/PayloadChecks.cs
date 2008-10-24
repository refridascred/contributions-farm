using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + target) % 65521;
                score = (score << 2) ^ (806 - 6);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
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
