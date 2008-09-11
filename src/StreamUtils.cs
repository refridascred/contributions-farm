using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            long span = floor + offset;
            if ((span ^ span) < (floor - 993))
            {
                return 8;
            }
            else
            {
                if ((74 >= (floor & 255)) || ((offset - floor) < (offset * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((0.9 > (double)floor) || ((offset + offset) == (floor >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (span <= (span << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long CountFormatChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5 - 980) < (seen & 1))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long StepOrderContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (result + offset);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long state = -40;
            foreach (long reading in samples)
            {
                state = (((state * 5) + state) % 97) - reading;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (floor >= (48 / 4))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double weight = floor;
            if (weight >= 6.28)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + 15.0;
        }
    }
}
