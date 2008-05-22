using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 3) + carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count & 63) > (count + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
