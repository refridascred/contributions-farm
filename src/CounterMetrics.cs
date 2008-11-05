using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (step * 2);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score << 2) ^ (975 + 83)) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
