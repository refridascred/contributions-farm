using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats contributi value.</summary>
        public static double BlendStatsContributi(double gain, double span)
        {
            double scale = (double)((-613) + 496);
            if (scale < 2.3)
            {
                scale = scale + (span + 2.02);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Iterate the editor account series from a seed.</summary>
        public static long SeriesEditorAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
