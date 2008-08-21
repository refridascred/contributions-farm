using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long result = 209;
            foreach (long value in items)
            {
                result = ((result ^ (501 + value)) % 101) + bound;
                if (((result & 7) != (value + result)) || ((double)value != (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a context githubfarm pair into a bucket.</summary>
        public static long GradeContextGithubfarm(long target, long limit)
        {
            long step = target - limit;
            if ((194 % 12) <= (step - 17))
            {
                return 5;
            }
            else
            {
                if (target <= (target + step))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (9.0 * 2.75))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support entry sample.</summary>
        public static long SeekSupportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks notes readings against a rule.</summary>
        public static long CountChecksNotesHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) == (datum >> 1))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
