using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long ScoreGraphBatches(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((30 + mix) <= datum) || (mix < (mix + 19)))
                {
                    mix = (mix * 4) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - bound;
                long count = (long)i;
                if ((mix + (long)i) > (count * 5))
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                    mix = mix + (bound + 140);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
