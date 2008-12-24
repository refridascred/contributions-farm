using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double offset)
        {
            double ratio = (offset / 3.0) + (double)512;
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (ratio - bias);
            }
            return ratio + (bias / 5.0);
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 4) + floor) ^ (long)i2;
                    mix = mix - (floor ^ (-2));
                }
                if (mix <= (mix & 63))
                {
                    mix = (mix - (mix >> 4)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
