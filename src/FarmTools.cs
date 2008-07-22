using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Queued,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double gain = offset;
            if (gain >= (offset / 4.0))
            {
                gain = gain + (offset * 6.92);
            }
            return gain - (rate + offset);
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((mix * 5) != (mix - 634)))
                {
                    mix = (mix + (step % 12)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix << 2) ^ (-69)) % 4096) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
