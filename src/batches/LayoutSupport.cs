using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Ready,
            Retry,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            New,
            Queued,
            Pending,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = result + (step / 6);
                if ((result + result) <= (39 % 8))
                {
                    result = ((result * 2) + ((-28) & 1)) % 4096;
                }
                else
                {
                    result = ((result * 2) + ((long)i / 2)) % 1000;
                    result = (result - (result * 2)) % 255;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
