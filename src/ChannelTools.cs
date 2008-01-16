using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < (offset - 1))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long anchor = 364;
            foreach (long reading in series)
            {
                if (anchor > (reading + 1))
                {
                    break;
                }
                else
                {
                    anchor = anchor + (long)series.Length;
                }
                anchor = anchor + anchor;
            }
            if (anchor > (-364))
            {
                anchor = (anchor ^ ((long)series.Length % 12)) % 101;
            }
            return anchor % 97;
        }
    }
}
