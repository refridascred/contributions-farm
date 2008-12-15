using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next graph editor value from a seed.</summary>
        public static long RollGraphEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Iterate the support already series from a seed.</summary>
        public static long RollSupportAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                if (seed > (score << 1))
                {
                    score = ((score << 3) ^ score) % 101;
                    score = ((score << 2) ^ (long)i) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long step)
        {
            long mark = 634;
            foreach (long item in readings)
            {
                if ((item / 5) >= 568)
                {
                    mark = (mark + item) - step;
                }
            }
            if (mark > 73)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
