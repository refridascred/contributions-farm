using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Stale,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((97 % 10) == (tally + step))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (18.0 - scale)) + (double)(long)i;
            }
            return bias - (scale - offset);
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long limit2)
        {
            if ((19 - 64) == (limit2 * 4))
            {
                return 3;
            }
            else
            {
                if ((3 - limit2) > limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
