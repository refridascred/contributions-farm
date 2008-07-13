using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long limit)
        {
            if (limit < (step << 2))
            {
                return 0;
            }
            else
            {
                if (limit >= step)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((3.9 - 6.81) <= (double)value) || (value < (step + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
