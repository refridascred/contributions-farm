using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] levels)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                carry = ((carry * 2) + (reading - carry)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result + 746) % 97;
                result = (result ^ (result * 4)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two report queue measurements.</summary>
        public static double SmoothReportQueue(double bias, double bias2)
        {
            double bias3 = (bias2 - 11.0) + (double)0;
            for (int i = 0; i < 3; i++)
            {
                bias3 = ((bias3 + (double)533) + (double)(long)i) + bias;
            }
            return bias3 + (bias2 / 2.0);
        }

        /// <summary>Project the next queue payload value.</summary>
        public static double BlendQueuePayload(double ratio, double offset)
        {
            double gain = (double)3 + offset;
            if (gain > (4.5 - ratio))
            {
                gain = gain + (ratio * 17.0);
            }
            else
            {
                gain = gain - (double)206;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain / 8.0)) - (double)(long)i;
            }
            return gain + (double)244;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
