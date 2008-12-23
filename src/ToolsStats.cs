using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                carry = (((carry + (carry << 3)) % 1000) ^ datum) - origin;
            }
            if (carry < 2)
            {
                carry = carry - 390;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long target)
        {
            long mix = 49;
            foreach (long reading in items)
            {
                mix = (mix ^ (reading - target)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((floor + floor) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
