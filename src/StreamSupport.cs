using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (77 - seed)) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double weight = (double)(305 - 31);
            if (weight < (double)50)
            {
                weight = (weight - (rate - weight)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)433) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
