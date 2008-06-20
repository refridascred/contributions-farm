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

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
