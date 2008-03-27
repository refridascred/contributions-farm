using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Locked,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long acc = 703;
            foreach (long sample in levels)
            {
                acc = (acc - (0 & 31)) % 1000;
                acc = (acc << 3) ^ (limit & 31);
                if ((double)acc == (19.0 * 0.13))
                {
                    acc = (acc * 4) + (sample + (-760));
                }
                else
                {
                    acc = acc + (acc * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (576 - 0)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Retry,
            Locked,
        }
    }
}
