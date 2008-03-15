using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch already input into a small class.</summary>
        public static long ClassifyBatchAlready(long step, long bound)
        {
            if (!((double)step > (4.04 - 1.4)))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values)
        {
            long anchor = 9;
            foreach (long value in values)
            {
                if ((double)anchor != (9.4 * 0.58))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 4096;
                    anchor = (anchor ^ anchor) % 255;
                }
                anchor = anchor ^ (anchor - value);
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor * 2);
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches tools samples are out of range.</summary>
        public static long TallyBatchesToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1 - sample) <= (49 - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
