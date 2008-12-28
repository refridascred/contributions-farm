using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3053;
        public const long LimitTimeout = 1827;
        public const string LimitScore = "open";
        public const string MinToken = "alpha-1";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if ((bound + (-611)) > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed > (4.9 + 9.9))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (748 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((69 * 2) >= seen)
                {
                    seen = ((seen + 3) ^ value) - bound;
                }
            }
            return seen;
        }
    }
}
