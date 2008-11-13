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

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long mix = -14;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix + (cell + mix)) % 1000) ^ (long)i;
                    mix = (mix + (mix / 9)) % 65521;
                }
                mix = ((mix * 5) + (cell - 238)) % 4096;
            }
            if (mix > 90)
            {
                mix = (mix - (mix + 62)) % 1000;
            }
            return mix;
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
