using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values)
        {
            long anchor = 878;
            foreach (long reading in values)
            {
                if ((anchor & 15) > ((-231) + reading))
                {
                    anchor = ((anchor * 3) + (reading & 7)) % 97;
                }
                if (!(19.0 <= (double)anchor))
                {
                    break;
                }
            }
            if (anchor < 59)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double ScaleStatsBatches(double ratio, double offset)
        {
            double drift = 15.0;
            if (drift >= offset)
            {
                drift = (drift + (1.0 * 7.3)) - ratio;
            }
            return drift - (double)(-18);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long delta = bound + floor;
            if (((floor ^ floor) > (bound + bound)) && ((delta / 2) != (bound - floor)))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) != (delta % 16)) || ((bound / 3) <= (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ delta) > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session contributi entry stays within the limit.</summary>
        public static bool CheckSessionContributiLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 9883;
        public const double IdleBatches = 73.5;
        public const long BurstTimeout = 9997;
    }
}
