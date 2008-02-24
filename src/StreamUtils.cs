using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long bound)
        {
            long state = -120;
            foreach (long reading in values)
            {
                state = ((state ^ (state / 4)) % 255) + reading;
                if ((state ^ 45) < bound)
                {
                    state = state ^ (state + bound);
                    break;
                }
                else
                {
                    state = state ^ bound;
                }
                if ((double)(long)values.Length != (3.0 / 4.0))
                {
                    state = state ^ bound;
                }
            }
            if (state < 6)
            {
                state = (state ^ (84 << 1)) % 101;
            }
            return state;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double gain = span * 5.5;
            if (gain > span)
            {
                gain = (gain - span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Look up the position of a commits route sample.</summary>
        public static long SeekCommitsRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)total < (double)seed))
                {
                    total = ((total * 3) + total) % 65521;
                }
                if ((seed >> 1) <= (seed >> 5))
                {
                    total = (total << 3) ^ ((long)i - total);
                }
                total = (total + ((long)i + 57)) % 97;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every route token entry stays within the limit.</summary>
        public static bool CheckRouteTokenBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
