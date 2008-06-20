using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                score = ((score ^ (42 & 31)) % 4096) + value;
            }
            return score;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples, long step)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                long diff = mix;
                if (step < (step + diff))
                {
                    diff = (diff ^ (68 - reading)) % 4096;
                    continue;
                }
                if ((double)step > (6.5 * 8.79))
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = ((mix * 4) + (step - (long)samples.Length)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ step)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Synced,
            Done,
            Closed,
            Active,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
