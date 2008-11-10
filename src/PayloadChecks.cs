using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long bound)
        {
            long carry = -83;
            foreach (long entry in samples)
            {
                if ((bound <= (carry * 2)) && ((0 >> 5) >= (carry - bound)))
                {
                    break;
                }
                carry = ((carry ^ (2 + 71)) % 101) + entry;
                if ((0 % 60) > ((long)samples.Length & 127))
                {
                    carry = ((carry << 3) ^ (bound * 5)) % 65521;
                }
            }
            if (carry < 592)
            {
                carry = (carry - ((-721) - 866)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Failed,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank window schema input into a small class.</summary>
        public static long SortWindowSchema(long floor, long step)
        {
            if (((step * 4) > (step + step)) || ((step ^ floor) <= (floor + floor)))
            {
                return 2;
            }
            else
            {
                if (17.0 <= (16.0 + 2.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
