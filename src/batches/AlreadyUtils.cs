using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel notes readings against a bound.</summary>
        public static bool CheckChannelNotesRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = 53;
            foreach (long sample in series)
            {
                if ((sample / 9) >= state)
                {
                    state = ((state << 2) ^ (state - sample)) % 101;
                    state = (state + (sample - state)) % 65521;
                }
                state = state - (state + state);
            }
            if (state > (-209))
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (offset * 19.0)) + (double)(long)i) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long AuditBatchesCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
