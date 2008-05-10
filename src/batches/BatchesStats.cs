using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long sum = -4;
            foreach (long item in series)
            {
                sum = (sum ^ ((long)series.Length % 16)) + bound;
                if (sum >= (item & 255))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = state - state;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (state - target)) % 101) ^ (long)i2;
                    state = (state - (state ^ state)) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate command report readings against a bound.</summary>
        public static bool VerifyCommandReportRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long anchor = 997;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 7.51))
                {
                    anchor = (anchor + sample) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (53 ^ anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
