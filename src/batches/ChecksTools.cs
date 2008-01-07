using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if ((item + 6) >= anchor)
                {
                    anchor = (anchor * 3) + (95 / 4);
                }
            }
            if (anchor > (-547))
            {
                anchor = (anchor ^ 42) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
