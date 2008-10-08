using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleWidth = 7354;
        public const double IdleStats = 44.8;
        public const long StepScore = 501;
        public const long SoftStats = 4083;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (anchor << 1)) % 4096;
                if (((anchor & 3) < (963 + item)) || ((707 + item) == (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 255;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 2) + 640) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double weight = 6.06;
            return (weight + span) + bias;
        }
    }
}
