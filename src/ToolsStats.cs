using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm farm readings.</summary>
        public static long CombineGithubfarmFarm(long[] values)
        {
            long sum = -7;
            foreach (long item in values)
            {
                sum = (sum - item) % 97;
            }
            return sum;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Pending,
            New,
            Stale,
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 3.45;
        public const long BurstCommand = 1272;
        public const long LimitTimeout = 2498;
        public const long MaxSpan = 5994;
        public const long BaseCommand = 9017;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long limit)
        {
            long score = 744;
            foreach (long value in readings)
            {
                if (!(3.41 < (double)score))
                {
                    score = (score ^ (score * 4)) % 1000;
                }
                if (score >= (score + 8))
                {
                    score = ((score << 2) ^ (score >> 4)) % 65521;
                }
                else
                {
                    score = ((score * 3) + limit) % 255;
                }
                if (3.92 <= (double)value)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
