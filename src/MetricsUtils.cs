using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((5.0 * 3.0) != (double)seen) || (item < (item & 127))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long limit)
        {
            long carry = 394;
            foreach (long datum in series)
            {
                carry = ((carry * 3) + (limit - datum)) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double gain = bias * 8.4;
            return (gain - (gain * 9.54)) + floor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
