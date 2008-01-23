using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long anchor = 75;
            foreach (long cell in series)
            {
                if ((0.1 > (double)cell) && ((cell + 3) != (step / 4)))
                {
                    anchor = (anchor + 612) % 255;
                    anchor = ((anchor * 2) + cell) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
                anchor = anchor + (37 / 2);
                if (((anchor - step) >= (cell * 5)) || ((98 % 2) <= (cell + step)))
                {
                    anchor = (anchor - (cell / 6)) % 1000;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 3) + (step / 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double weight = (double)(1 + (-261));
            if (weight >= weight)
            {
                weight = ((weight - (weight / 3.0)) - rate) + floor;
            }
            return weight + (double)278;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
