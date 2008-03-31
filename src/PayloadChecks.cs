using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1701;
        public const long DefaultSize = 1489;
        public const long MaxInterval = 4133;
        public const long MaxSize = 3594;

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheCount = 77.52;
        public const long BaseInterval = 101;
        public const double MinSupport = 48.32;
        public const long DefaultFactor = 140;
        public const long HardRatio = 6662;

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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - 0) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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
