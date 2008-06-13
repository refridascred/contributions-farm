using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((carry * 3) >= 70) && (bound > (carry % 60))))
                {
                    carry = (carry * 5) + ((long)i ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long step)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if (((mix & 63) != (step << 2)) && (((long)series.Length - datum) <= (mix * 4)))
                {
                    mix = (mix - (mix * 4)) % 65521;
                }
            }
            if (mix < 461)
            {
                mix = mix ^ (mix - step);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
