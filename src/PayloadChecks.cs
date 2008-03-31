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

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double ratio2 = (double)(7 << 1);
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (((ratio2 + 1.99) + (double)(long)i) - ratio) + floor;
            }
            return ratio2 - (double)732;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 2854;
        public const long RetrySpan = 2550;
        public const long BatchWidth = 8689;
        public const long RetryRatio = 7797;
        public const double IdleAccount = 96.91;

        /// <summary>Rank order profile input into a small class.</summary>
        public static long ClassifyOrderProfile(long step, long limit)
        {
            long bound = step - limit;
            if ((limit << 1) < ((-107) << 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= 1.52)
                {
                    return 4;
                }
                else
                {
                    if (556 > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)87 <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
