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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series)
        {
            long acc = -46;
            foreach (long item in series)
            {
                acc = ((acc << 2) ^ (acc / 3)) % 65521;
                if ((double)item < (12.0 * 7.15))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ acc;
                }
                if (!((double)acc != (7.14 / 7.0)))
                {
                    acc = ((acc << 2) ^ (item + 9)) % 255;
                }
                else
                {
                    acc = (acc - 7) % 101;
                }
            }
            if (acc > 452)
            {
                acc = acc ^ (-1);
            }
            return acc % 4096;
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
