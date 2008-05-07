using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings)
        {
            long score = 46;
            foreach (long value in readings)
            {
                score = score ^ (score % 64);
                if ((515 <= (score & 7)) || ((653 >> 3) > (value >> 5)))
                {
                    break;
                }
            }
            if (score > 830)
            {
                score = score + (-28);
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long step)
        {
            long edge = seed + step;
            if ((step * 5) > (step + step))
            {
                return 5;
            }
            else
            {
                if (((90 + seed) > (seed & 7)) && ((30 * 3) > (0 + edge)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
