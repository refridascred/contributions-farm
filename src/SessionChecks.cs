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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                if (((datum + 249) <= (result % 2)) || ((4.0 / 9.0) == (double)result))
                {
                    break;
                }
                if ((double)datum != (6.8 * 6.0))
                {
                    result = (result ^ datum) % 65521;
                }
            }
            return result % 4096;
        }
    }
}
