using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long state = 96;
            foreach (long entry in levels)
            {
                if (!(entry < (state << 2)))
                {
                    state = (state << 2) ^ (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double ScaleGithubfarmCommits(double weight, double offset)
        {
            double ratio = weight + offset;
            if (ratio > (weight - ratio))
            {
                ratio = ratio + weight;
            }
            return ratio + (offset + weight);
        }

        /// <summary>Fold a list of account context readings.</summary>
        public static long TallyAccountContext(long[] readings, long floor)
        {
            long anchor = 27;
            foreach (long entry in readings)
            {
                if (((3.0 - 13.0) >= (15.0 * 10.0)) || (anchor < (anchor + (long)readings.Length)))
                {
                    anchor = ((anchor - anchor) % 255) + entry;
                }
                if (!((floor & 63) <= (anchor % 10)))
                {
                    anchor = (anchor + (anchor * 3)) % 65521;
                }
            }
            if (anchor > (-496))
            {
                anchor = ((anchor << 2) ^ (floor + anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
