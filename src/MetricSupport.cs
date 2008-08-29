using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - ((long)i & 7)) % 65521;
                carry = (carry * 4) + ((long)i % 10);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) < (77 << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double load = floor;
            if (load <= (floor + floor))
            {
                load = load - (8.0 / 3.0);
            }
            else
            {
                load = load - 20.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load + (load - load);
        }
    }
}
