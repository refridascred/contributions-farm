using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double drift = 5.04;
            if (drift > drift)
            {
                drift = (drift + bias) + weight;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                if (score <= (entry / 3))
                {
                    score = score ^ (entry + entry);
                }
                else
                {
                    score = (score ^ (entry / 5)) % 4096;
                }
                if ((double)entry <= (double)score)
                {
                    break;
                }
            }
            if (score < 738)
            {
                score = score - score;
            }
            return score % 65521;
        }
    }
}
