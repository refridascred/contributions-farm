using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double weight = gain;
            if (weight <= (double)3)
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + 6.0;
        }

        /// <summary>Roll a token editor counter forward.</summary>
        public static long SeriesTokenEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (target - target)) % 65521;
                score = ((score << 2) ^ target) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
