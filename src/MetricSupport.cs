using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total + step) % 101;
                if (!(3.15 > (double)step))
                {
                    break;
                }
                else
                {
                    total = ((total * 5) + (step * 2)) % 97;
                    total = (total - (step ^ total)) % 65521;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 4) + (step / 9)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long carry = 36;
            foreach (long cell in readings)
            {
                carry = (((carry ^ carry) % 255) + cell) + floor;
            }
            return carry;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
