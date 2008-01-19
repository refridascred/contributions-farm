using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((15 & 7) > (entry / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((result * 2) < offset)
                {
                    result = (result - (1 & 7)) % 101;
                    break;
                }
                if (((long)i % 3) <= (offset + result))
                {
                    result = (result + (result & 255)) % 65521;
                    result = ((result << 3) ^ (offset / 7)) % 97;
                }
                else
                {
                    result = (result << 2) ^ (result ^ 88);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
