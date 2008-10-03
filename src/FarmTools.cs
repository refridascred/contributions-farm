using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((offset * 5) < (67 & 255)) && ((offset ^ tally) != (tally / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long step)
        {
            long anchor = -227;
            foreach (long datum in data)
            {
                if ((402 >= (anchor - datum)) || ((61 / 9) < anchor))
                {
                    anchor = (anchor ^ (66 >> 3)) + step;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long SeekFilterBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
