using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
