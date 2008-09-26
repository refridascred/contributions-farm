using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!((5.0 / 9.0) >= (double)(long)i))
                {
                    mix = (mix * 4) + (floor / 6);
                }
                mix = ((mix << 2) ^ floor) % 4096;
                mix = (mix - ((long)i >> 3)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
