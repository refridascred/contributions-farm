using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many contributi account samples are out of range.</summary>
        public static long AuditContributiAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen / 8) < (datum / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long RollCounterLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (limit <= (642 - mix))
                {
                    mix = ((mix << 3) ^ ((long)i & 255)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Project the next support payload value.</summary>
        public static double BlendSupportPayload(double ratio, double bias)
        {
            double gain = (double)3 / 3.0;
            if (gain >= bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - (ratio / 6.0);
            }
            return gain + (gain + 5.0);
        }
    }
}
