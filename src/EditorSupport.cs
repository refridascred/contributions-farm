using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mark = 2;
            foreach (long reading in samples)
            {
                if ((double)reading < (7.0 - 7.6))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
            }
            if (mark < 67)
            {
                mark = (mark + (mark % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if ((mix + 477) > (mix - mix))
                {
                    mix = (mix ^ (mix % 97)) + sample;
                }
                else
                {
                    mix = ((mix << 3) ^ ((-106) / 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = acc;
                if (((4.01 * 0.23) >= (double)step) && ((double)step < (5.0 + 4.0)))
                {
                    acc = (acc + (380 + 62)) % 1000;
                    acc = ((acc << 2) ^ (step & 15)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                    step = ((step * 3) + floor) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
