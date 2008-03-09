using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long TotalCounterFilter(long[] values, long bound)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if (bound >= (state / 6))
                {
                    state = (state + (datum + datum)) % 101;
                }
            }
            if (state < 9)
            {
                state = ((state * 5) + ((long)values.Length << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Look up the position of a schema farm sample.</summary>
        public static long SeekSchemaFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
