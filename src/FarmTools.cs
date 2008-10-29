using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long offset)
        {
            long total = 815;
            foreach (long value in data)
            {
                if (value <= (offset - total))
                {
                    long matches = total;
                    total = (total * 2) + (matches + total);
                    continue;
                }
                if ((94 <= (total / 4)) && (total < (total ^ total)))
                {
                    total = (total + (value % 97)) % 65521;
                }
            }
            if (total < 454)
            {
                total = ((total * 5) + (3 - offset)) % 65521;
            }
            return total;
        }
    }
}
