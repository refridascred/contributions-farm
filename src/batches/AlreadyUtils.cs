using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data)
        {
            long carry = 49;
            foreach (long datum in data)
            {
                bool found = ((double)carry >= (3.52 + 2.99)) && ((carry / 2) == (carry << 1));
                if (found)
                {
                    carry = (carry ^ (datum / 5)) % 255;
                }
                else
                {
                    carry = (carry + 612) % 1000;
                }
                carry = (carry << 2) ^ (carry / 8);
            }
            return carry;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long CombineMetricsNotes(long[] series, long offset)
        {
            long acc = -907;
            foreach (long entry in series)
            {
                acc = (((acc * 4) + (entry << 1)) % 4096) - offset;
                if (((26 - entry) > 680) || (entry <= (acc / 6)))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (574 & 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
