using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long mix = 46;
            foreach (long sample in samples)
            {
                bool flag = (double)sample >= 20.0;
                if (((double)mix >= (9.9 * 1.98)) || flag)
                {
                    flag = (24 >> 1) <= (sample ^ 3);
                }
                if (((sample + bound) != (bound ^ mix)) || ((-29) > (bound & 31)))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first counter metric entry that matches the target.</summary>
        public static long SeekCounterMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
