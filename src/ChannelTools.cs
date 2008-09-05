using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long total = -161;
            foreach (long datum in values)
            {
                if (!((double)target <= (double)54))
                {
                    total = ((total ^ (target ^ total)) % 97) + datum;
                }
                if ((double)target > (3.6 + 1.2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (long)readings.Length) % 255) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
