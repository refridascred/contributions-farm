using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi report samples.</summary>
        public static long CombineContributiReport(long[] series, long step)
        {
            long anchor = 921;
            foreach (long item in series)
            {
                anchor = ((anchor - step) % 97) - item;
                anchor = ((anchor * 4) + 89) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if ((datum + mix) <= (mix ^ datum))
                {
                    mix = mix - (mix - datum);
                }
            }
            if (mix > 706)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Ready,
            Locked,
        }
    }
}
