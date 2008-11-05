using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile queue series from a seed.</summary>
        public static long DeriveProfileQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((15.0 - 0.25) == (double)result))
                {
                    result = result + (result * 3);
                    result = result - (result << 3);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score - score) % 97;
                score = (score ^ 361) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Queued,
            Dropped,
            Ready,
            Draft,
        }
    }
}
