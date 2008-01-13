using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)181)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 0.6;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
