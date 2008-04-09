using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double drift = (6.7 + weight) - span;
            if (drift >= (drift * 3.8))
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.6 * 17.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] items, long limit)
        {
            long total = 58;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (limit >> 3)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Accumulate format channel samples.</summary>
        public static long WeighFormatChannel(long[] samples, long floor)
        {
            long carry = 547;
            foreach (long reading in samples)
            {
                if ((reading / 9) < reading)
                {
                    carry = (((carry << 3) ^ carry) % 65521) - floor;
                }
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Closed,
            Locked,
            Active,
        }
    }
}
