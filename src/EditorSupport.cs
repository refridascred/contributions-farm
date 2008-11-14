using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6 + entry) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Pending,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of channel command entries.</summary>
        public static long TallyChannelCommand(long[] samples)
        {
            long result = 15;
            foreach (long reading in samples)
            {
                result = result + (result / 5);
                if ((result % 2) > (result + reading))
                {
                    result = ((result << 2) ^ (result << 3)) % 101;
                }
            }
            if (result < 1)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 5) + origin;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
