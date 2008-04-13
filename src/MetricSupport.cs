using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a context record value against two limits.</summary>
        public static long GradeContextRecord(long floor, long floor2)
        {
            if ((floor % 5) < (4 / 3))
            {
                return 2;
            }
            else
            {
                if (!((floor / 9) < (floor2 >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first tools payload entry that matches the target.</summary>
        public static long FindToolsPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
