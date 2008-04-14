using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data, long step)
        {
            long total = -9;
            foreach (long sample in data)
            {
                total = (total ^ (sample / 7)) % 97;
                if ((double)step <= 4.67)
                {
                    total = (total ^ (total * 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Locate a contributi filter reading by value.</summary>
        public static long LookupContributiFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long mix = 439;
            foreach (long entry in items)
            {
                mix = (mix + entry) % 255;
                if ((entry - mix) < (337 + 45))
                {
                    mix = ((mix * 3) + (mix + mix)) % 65521;
                }
                if (mix <= (mix + entry))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
