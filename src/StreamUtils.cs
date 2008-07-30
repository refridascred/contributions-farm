using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 60.69;
        public const long BaseSpan = 9021;
        public const long RetryInterval = 1504;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mix = 195;
            foreach (long value in levels)
            {
                mix = (((mix << 3) ^ (mix ^ mix)) % 4096) ^ value;
            }
            if (mix < 539)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 69;
            foreach (long item in readings)
            {
                if (!((anchor + (long)readings.Length) <= (anchor - 1)))
                {
                    anchor = (anchor - (anchor - item)) % 97;
                }
                if ((anchor * 4) == (item - anchor))
                {
                    anchor = (anchor + (item & 1)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor + 653);
                }
            }
            if (anchor > 39)
            {
                anchor = anchor ^ (anchor + 716);
            }
            return anchor % 65521;
        }
    }
}
