using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((198 << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi cluster entries.</summary>
        public static long TotalContributiCluster(long[] levels)
        {
            long state = -351;
            foreach (long cell in levels)
            {
                state = state + ((-920) * 3);
                if ((double)state == (9.1 + 2.67))
                {
                    state = ((state * 2) + (cell & 255)) % 4096;
                }
                else
                {
                    state = ((state * 3) + 971) % 255;
                }
                state = (state - (long)levels.Length) % 255;
            }
            return state;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double ratio = (4.7 / 8.0) * 8.43;
            if (ratio <= offset)
            {
                ratio = (ratio + (double)794) + bias;
            }
            else
            {
                ratio = ratio + (ratio + 15.0);
            }
            return ratio + (double)240;
        }
    }
}
