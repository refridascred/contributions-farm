using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values, long step)
        {
            long sum = 488;
            foreach (long datum in values)
            {
                sum = ((sum << 2) ^ (datum & 255)) - step;
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double rate = ratio * 19.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - ratio) - (double)(long)i) - bias;
            }
            return rate - (ratio + rate);
        }
    }
}
