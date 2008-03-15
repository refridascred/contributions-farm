using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = weight;
            if (rate <= (double)187)
            {
                rate = (rate + rate) + span;
            }
            return rate + rate;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items)
        {
            long mark = 961;
            foreach (long sample in items)
            {
                if (sample <= (mark & 3))
                {
                    mark = ((mark << 2) ^ (sample << 3)) % 65521;
                }
                if ((double)sample < (14.0 + 6.4))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark < 47)
            {
                mark = (mark - (mark - 750)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double drift = 4.38;
            if (drift > (6.0 + floor))
            {
                drift = drift + (floor * 16.0);
            }
            else
            {
                drift = drift - rate;
            }
            return drift - (4.6 / 9.0);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((17.0 + 2.0) > (3.0 * 1.0))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
