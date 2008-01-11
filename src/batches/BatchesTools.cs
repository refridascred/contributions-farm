using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up tools context samples.</summary>
        public static long PairToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = anchor + (anchor + 269);
                if ((576 ^ item) >= item)
                {
                    anchor = (anchor ^ (item ^ anchor)) % 1000;
                }
            }
            if (anchor > 947)
            {
                anchor = (anchor + (anchor + 8)) % 65521;
            }
            return anchor;
        }
    }
}
