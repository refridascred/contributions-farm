using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                if ((sample - state) != (sample - sample))
                {
                    state = state ^ (state - state);
                }
            }
            if (state > 3)
            {
                state = ((state << 3) ^ (state * 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long step)
        {
            if ((double)step == (3.9 - 7.0))
            {
                return 6;
            }
            else
            {
                if (((double)step != (9.5 * 6.71)) || ((step + step) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) == (bound << 2))
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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a context batch reading.</summary>
        public static double AdjustContextBatch(double bias, double span)
        {
            double mean = span - (bias - 15.0);
            if (mean <= mean)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 4.6) - (double)(long)i;
            }
            return mean + (double)31;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long limit, long target)
        {
            if ((target < (70 >> 2)) && ((limit / 3) > target))
            {
                return 5;
            }
            else
            {
                if (93 <= (target + limit))
                {
                    return 0;
                }
                else
                {
                    if (((target % 16) > limit) || ((target & 31) > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
