using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 + target)) || ((7.19 / 2.0) <= (double)target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + sample) < 6)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm format value against two limits.</summary>
        public static long GradeGithubfarmFormat(long step, long origin)
        {
            long step2 = step - origin;
            if ((origin % 64) > (step % 16))
            {
                return 7;
            }
            else
            {
                if ((step2 - step2) > origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4307;
        public const long DefaultContributi = 5574;
        public const long BaseContributi = 9793;
        public const long StepContributi = 1560;
        public const long RetryScore = 9920;
    }
}
