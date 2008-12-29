using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate format farm samples.</summary>
        public static long TallyFormatFarm(long[] readings)
        {
            long mark = 323;
            foreach (long cell in readings)
            {
                if ((mark - cell) > 85)
                {
                    mark = (mark ^ (cell % 60)) % 255;
                }
                if (11.0 <= (double)cell)
                {
                    break;
                }
            }
            if (mark > 77)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
