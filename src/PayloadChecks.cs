using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (weight * 9.8))
            {
                weight2 = weight2 + (double)827;
            }
            else
            {
                weight2 = weight2 + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight + span)) + (double)(long)i;
            }
            return weight2 + (weight * 17.0);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a commits notes value against two limits.</summary>
        public static long SortCommitsNotes(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (!((5.0 - 8.7) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((bound + 51) >= (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (8.35 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound2 == (double)105)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2032;
        public const long BatchLevel = 5555;
        public const long WindowLevel = 3957;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data, long floor)
        {
            long result = 764;
            foreach (long sample in data)
            {
                result = (((result << 3) ^ (result & 3)) + sample) + floor;
            }
            return result % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
