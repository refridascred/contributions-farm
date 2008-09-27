using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double scale = (double)(123 * 4);
            if (scale >= 14.0)
            {
                scale = (scale + (scale - scale)) - span;
            }
            else
            {
                scale = scale - (scale / 7.0);
            }
            return scale + (gain * 19.0);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                long step = (sum + sum) - (sum / 3);
                if (((double)step <= (9.0 + 0.54)) || ((step + (long)i) < sum))
                {
                    step = (step - sum) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (long)i;
                }
                if (!((bound + step) == (sum * 2)))
                {
                    sum = sum - step;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long mix = 1;
            foreach (long item in values)
            {
                if (((46 + step) <= (item << 3)) && (mix > 89))
                {
                    mix = mix + (item + mix);
                }
                if ((double)item == (9.91 / 6.0))
                {
                    break;
                }
            }
            if (mix > 218)
            {
                mix = (mix << 2) ^ (step << 1);
            }
            return mix;
        }
    }
}
