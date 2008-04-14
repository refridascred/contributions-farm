using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long TallyStreamAccountOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 7) == (entry + entry))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
