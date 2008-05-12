using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(seen >= (seed ^ datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double weight = (double)(7 >> 2);
            if (weight > (1.89 + 6.8))
            {
                weight = (weight + bias) - scale;
            }
            return weight + (double)964;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (floor >> 4)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ floor) % 65521) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
