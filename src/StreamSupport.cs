using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double weight = scale * 18.0;
            if (weight < (double)446)
            {
                weight = (weight + weight) + offset;
            }
            return weight - 5.42;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool ValidateSessionRecordBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
