using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long CountStatsMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (10.0 * 8.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long floor)
        {
            long total = 756;
            foreach (long sample in data)
            {
                if ((17.0 - 20.0) > (double)total)
                {
                    total = (((total << 3) ^ floor) % 255) ^ sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long state = 6;
            foreach (long item in samples)
            {
                if (((67 >> 1) < item) || ((state >> 2) < (item + item)))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of checks already readings.</summary>
        public static long ScoreChecksAlready(long[] samples)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                mix = ((mix * 2) + mix) % 97;
                mix = mix ^ sample;
                if ((sample - sample) > mix)
                {
                    mix = mix + 607;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
