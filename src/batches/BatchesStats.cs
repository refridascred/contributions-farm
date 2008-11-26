using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Locked,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long step)
        {
            long result = 1;
            foreach (long reading in series)
            {
                result = (result - (reading ^ reading)) % 97;
                if (!((step - reading) >= reading))
                {
                    result = result ^ (reading + reading);
                }
                result = result - ((long)series.Length - reading);
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count < (count << 3))
                {
                    count = ((count + 3) + sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                if ((state >> 1) < (state + state))
                {
                    state = state ^ (state << 1);
                }
                else
                {
                    state = (state * 4) + datum;
                    state = (state - (81 << 1)) % 255;
                }
                if ((double)datum >= (8.44 * 7.0))
                {
                    state = state - (state >> 1);
                }
                if (((state + datum) == (state - state)) || ((double)state != (7.2 + 5.0)))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
