using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (5.87 > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long seed)
        {
            if ((0 + 0) >= seed)
            {
                return 6;
            }
            else
            {
                if ((step << 3) > (step - (-313)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (seed % 24)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result * 5) + 1) % 101) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Grade a githubfarm window value against two limits.</summary>
        public static long GradeGithubfarmWindow(long floor, long offset)
        {
            if ((16.0 - 4.81) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (14.0 * 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((floor <= (52 / 9)) || ((double)floor == (1.41 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (1.8 * 6.8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
