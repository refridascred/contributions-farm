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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
