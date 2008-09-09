using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool VerifyCounterRecordRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support entry reading.</summary>
        public static double AdjustSupportEntry(double weight, double bias)
        {
            double mean = weight;
            if (mean > bias)
            {
                mean = mean - (double)87;
            }
            return mean + mean;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if ((mix * 4) == ((long)i << 3))
                {
                    mix = (mix + ((long)i + mix)) % 97;
                }
                if ((double)mix < (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
