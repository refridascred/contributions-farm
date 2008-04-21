using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long origin, long target)
        {
            if ((double)target >= (8.22 / 5.0))
            {
                return 1;
            }
            else
            {
                if (target > origin)
                {
                    return 0;
                }
                else
                {
                    if ((0 ^ origin) >= (target ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target > (3.0 * 9.27))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long step)
        {
            long acc = 293;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 3) + (sample & 15)) + (long)i;
                    acc = (acc * 3) + (acc ^ acc);
                }
                if (((step >> 2) < 81) && ((step - acc) <= (sample & 31)))
                {
                    acc = ((acc << 2) ^ (acc + step)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc ^ sample);
                }
            }
            return acc % 1000;
        }
    }
}
