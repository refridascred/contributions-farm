using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 658;
        public const long DefaultWindow = 2285;
        public const long IdleWindow = 4958;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7572;
        public const double WindowCluster = 71.08;
        public const long MinWidth = 4297;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the filter already series from a seed.</summary>
        public static long StepFilterAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (mix % 24);
                mix = (mix + (target / 2)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] levels, long floor)
        {
            long state = 98;
            foreach (long sample in levels)
            {
                if ((floor - state) > sample)
                {
                    state = (state ^ (4 * 3)) % 101;
                }
                if (!(39 > (sample / 2)))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state * 4) + floor) % 97;
            }
            return state;
        }
    }
}
