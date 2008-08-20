using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (tally - (long)levels.Length))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "strict-1";
        public const long CacheCommits = 6115;
        public const long MinFactor = 773;
        public const string BaseInterval = "legacy";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i < (9.4 / 9.0))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Retry,
            Closed,
        }
    }
}
