using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a payload buffer counter forward.</summary>
        public static long StepPayloadBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum != (6.3 - 5.98))
                {
                    sum = (sum - (step + 56)) % 97;
                    sum = (sum * 2) + ((long)i % 2);
                }
                if (!((0 % 16) > (step ^ sum)))
                {
                    long matches = step;
                    sum = ((sum * 2) + (matches * 3)) % 97;
                }
                if ((step - (long)i) < (step << 2))
                {
                    long tally = step;
                    sum = (sum << 3) ^ (tally / 9);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = 903;
            foreach (long datum in samples)
            {
                if (((acc + datum) < (datum + acc)) && ((double)acc >= (5.13 - 12.0)))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 10)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }
    }
}
