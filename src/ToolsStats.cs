using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
