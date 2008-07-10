using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches >> 1) > (long)values.Length) && ((double)bound > (double)(-55)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1057;
        public const long BurstSpan = 3844;
        public const long StepCommand = 4529;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Active,
            Done,
            Locked,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings)
        {
            long mix = -499;
            foreach (long value in readings)
            {
                if ((6.6 - 0.2) != (double)mix)
                {
                    mix = ((mix << 2) ^ (value + 29)) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ value;
                }
            }
            if (mix > 804)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
