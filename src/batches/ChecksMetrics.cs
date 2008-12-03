using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen % 24) != (seen ^ datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < 781)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long bound)
        {
            long result = 22;
            foreach (long item in series)
            {
                if (result <= (bound * 3))
                {
                    result = result ^ (result << 3);
                }
                if (((76 - bound) <= (item ^ result)) || ((item + item) > (item << 2)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long step = seed - target;
            if (((9.25 / 7.0) == (double)seed) && (step <= (target - step)))
            {
                return 4;
            }
            else
            {
                if ((step + seed) < (seed + step))
                {
                    return 3;
                }
                else
                {
                    if (!(target > (step % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 7) != (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
        }
    }
}
