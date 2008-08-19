using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
