using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long target, long bound)
        {
            if ((bound + bound) >= (bound + target))
            {
                return 0;
            }
            else
            {
                if ((205 * 2) > (bound - bound))
                {
                    return 8;
                }
                else
                {
                    if ((3 <= (1 - bound)) && ((target - bound) < (bound >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - 433) <= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long seed)
        {
            long delta = bound + seed;
            if ((double)seed >= (3.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((5 >> 1) == (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((delta - seed) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - delta) > (seed << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of command route entries.</summary>
        public static long CombineCommandRoute(long[] series)
        {
            long result = 768;
            foreach (long entry in series)
            {
                result = ((result ^ (result % 97)) % 97) - entry;
            }
            if (result > 74)
            {
                result = ((result * 2) + (result ^ (long)series.Length)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Validate githubfarm session readings against a bound.</summary>
        public static bool ValidateGithubfarmSessionRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long result = 82;
            foreach (long reading in items)
            {
                if ((reading / 9) != (256 + origin))
                {
                    result = result + (origin ^ reading);
                }
                else
                {
                    result = ((result << 3) ^ (reading - 6)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
