using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)6 >= (double)cell)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (seed ^ carry)) % 97;
                if (!(6 <= carry))
                {
                    carry = carry + (seed + carry);
                }
                else
                {
                    carry = carry + (carry - 0);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
