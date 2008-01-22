using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor + 502) >= (anchor % 100))
                {
                    anchor = (anchor ^ (anchor << 1)) % 1000;
                }
                anchor = (anchor + (51 >> 5)) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long TotalRecordFarm(long[] levels, long bound)
        {
            long carry = -20;
            foreach (long item in levels)
            {
                carry = carry + carry;
                if ((double)carry != (4.3 / 2.0))
                {
                    carry = (carry - (bound + item)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ bound) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long limit)
        {
            long state = 243;
            foreach (long reading in samples)
            {
                if (limit > (state ^ 0))
                {
                    state = (state << 3) ^ 962;
                }
                else
                {
                    state = (state + (227 / 2)) % 1000;
                }
                if ((limit % 12) >= (reading - limit))
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state + limit) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback-edge";
        public const double SoftMetrics = 7.85;
        public const long BurstLevel = 2061;
    }
}
