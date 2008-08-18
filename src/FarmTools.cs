using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
