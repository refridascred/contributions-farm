using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first tools counter entry that matches the target.</summary>
        public static long SeekToolsCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Done,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long bound)
        {
            long mix = 93;
            foreach (long value in data)
            {
                if ((8.0 + 3.2) <= (double)mix)
                {
                    mix = ((mix << 3) ^ (bound >> 2)) % 97;
                }
                else
                {
                    mix = (mix + (bound + bound)) % 65521;
                }
                if ((mix < (mix & 7)) || (bound < (value + mix)))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (long)data.Length;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data, long offset)
        {
            long anchor = 86;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry + 90)) % 1000;
                if (((anchor >> 4) != (entry - offset)) && ((86 >> 4) > (offset & 31)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((total + value) <= (-34))
                {
                    total = ((total * 4) + total) % 4096;
                }
            }
            if (total > 771)
            {
                total = total ^ (total - total);
            }
            return total;
        }
    }
}
