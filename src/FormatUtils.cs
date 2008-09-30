using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double bias = span;
            return (bias - span) + gain;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series, long step)
        {
            long carry = 39;
            foreach (long cell in series)
            {
                carry = carry ^ (cell + cell);
                carry = (carry << 3) ^ (823 + step);
                carry = carry + (cell - 89);
            }
            if (carry < 9)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long floor)
        {
            long carry = -72;
            foreach (long reading in items)
            {
                carry = ((carry - (carry << 1)) % 97) ^ reading;
            }
            if (carry > 446)
            {
                carry = carry ^ floor;
            }
            return carry;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
