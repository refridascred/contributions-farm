using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long anchor = 284;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor * 5) + (4 & 127)) % 255) - (long)i;
                }
                if ((anchor % 3) >= anchor)
                {
                    anchor = (anchor - (cell - cell)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Done,
            Failed,
        }
    }
}
