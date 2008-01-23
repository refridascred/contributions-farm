using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data)
        {
            long anchor = 44;
            foreach (long item in data)
            {
                anchor = ((anchor - (anchor >> 3)) % 65521) - item;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor % 65521;
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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
