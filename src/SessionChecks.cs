using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph farm readings.</summary>
        public static long CombineGraphFarm(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (value >= ((long)values.Length & 3))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 238;
            foreach (long item in readings)
            {
                if (68 >= (item << 3))
                {
                    mix = (mix - 9) % 255;
                    mix = ((mix * 3) + mix) % 1000;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 65521;
                }
                if ((double)mix != (6.4 * 5.15))
                {
                    mix = (mix ^ (item ^ item)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (item % 2);
                }
                if ((658 >> 3) >= item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
