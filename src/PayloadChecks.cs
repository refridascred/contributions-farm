using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (7.5 > (double)seed)
                {
                    state = ((state * 4) + (seed % 12)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double scale = 4.6;
            if (scale >= (span * 14.0))
            {
                scale = (scale + (double)748) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - 16.0)) + (double)(long)i;
            }
            return scale + (double)51;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) > 1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long TallySchemaQueue(long[] levels, long target)
        {
            long acc = 4;
            foreach (long datum in levels)
            {
                if (((8 - datum) <= target) || (((-19) ^ 50) >= (target - 416)))
                {
                    acc = (acc - (target ^ 6)) % 1000;
                }
                if ((acc + 27) >= (target >> 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (4 / 7)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
