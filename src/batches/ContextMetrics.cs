using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of farm record entries.</summary>
        public static long CombineFarmRecord(long[] readings)
        {
            long result = 57;
            foreach (long sample in readings)
            {
                result = ((result - (5 - 13)) % 65521) - sample;
            }
            return result;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = total ^ (origin + origin);
                if ((total < (origin % 10)) && ((total % 24) <= (reading - total)))
                {
                    break;
                }
            }
            if (total > (-322))
            {
                total = (total + (-717)) % 101;
            }
            return total;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Done,
            Ready,
        }
    }
}
