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

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (99 << 2))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
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
