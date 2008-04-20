using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - matches) > (value << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long anchor = -560;
            foreach (long item in samples)
            {
                anchor = (anchor - (bound << 1)) % 4096;
                if ((9.41 / 5.0) != (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + item)) % 101;
                    anchor = anchor ^ (anchor & 3);
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = (anchor + (item ^ bound)) % 101;
                }
                if (!((double)bound != (double)anchor))
                {
                    anchor = (anchor + (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (tally + tally))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state << 3) ^ (596 - sample)) - (long)i;
                    state = (state + (state / 3)) % 1000;
                }
                state = (state << 2) ^ sample;
                if (sample <= (sample << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((20.0 / 3.0) > (double)cell)
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
