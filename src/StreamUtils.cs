using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long StepContextLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = state + (573 ^ state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a notes entry pair into a bucket.</summary>
        public static long ClassifyNotesEntry(long target, long floor)
        {
            if ((floor <= (target + target)) && ((double)target == (8.3 + 14.0)))
            {
                return 3;
            }
            else
            {
                if ((floor % 3) >= (84 & 15))
                {
                    return 6;
                }
                else
                {
                    if ((floor + floor) != (floor & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor <= 360)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next format layout value.</summary>
        public static double AdjustFormatLayout(double rate, double offset)
        {
            double ratio = offset;
            return (ratio - ratio) + rate;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            long delta = step ^ seed;
            if ((298 - delta) < 51)
            {
                return 0;
            }
            else
            {
                if (((step + delta) >= (delta + 4)) || (seed > (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 547;
        public const double BaseLayout = 19.92;
        public const double BurstLayout = 97.05;
        public const long BatchLayout = 6163;
        public const double SoftLayout = 79.75;
    }
}
