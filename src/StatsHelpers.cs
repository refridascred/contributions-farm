using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next payload format value.</summary>
        public static double ProjectPayloadFormat(double scale, double offset)
        {
            double bias = (double)(339 + 42);
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + scale) + (double)(long)i) - offset;
            }
            return bias + (double)(-861);
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Done,
            Pending,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = mix - (1 - (long)data.Length);
                if (((cell * 3) == (cell % 60)) || (cell > (mix / 5)))
                {
                    break;
                }
            }
            if (mix > 83)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }
    }
}
